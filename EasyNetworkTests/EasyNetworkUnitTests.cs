//-----------------------------------------------------------------------------
// EasyNetworkUnitTests.cs Copyright(c) 2015 Jacob Christensen and Bryan Hansen
//
// Permission is hereby granted, free of charge, to any person obtaining a copy 
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
// THE SOFTWARE.
//-----------------------------------------------------------------------------

namespace EasyNetworkTests
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// Unit tests for the EasyNetwork classes
    /// </summary>
    [TestClass]
    public class EasyNetworkUnitTests
    {
        /// <summary> Holds the last object received by the clientOne objects in the tests </summary>
        private Object clientOneDataReceived;

        /// <summary> Holds the last object received by the clientTwo objects in the tests </summary>
        private Object clientTwoDataReceived;

        /// <summary> Data received by each of the clients in the test which pushes to many clients </summary>
        private Dictionary<Guid, Object> dataReceivedPerClient = new Dictionary<Guid, Object>();

        /// <summary> Holds objects received in the server and the corresponding client IDs </summary>
        private List<Tuple<Object, Guid>> serverObjectsReceived = new List<Tuple<Object, Guid>>();

        /// <summary>
        /// Tests that multiple clients can send data to the server
        /// </summary>
        [TestMethod]
        public void ClientToServer()
        {
            EasyNetwork.Server server = new EasyNetwork.Server("tcp://*:1982");
            EasyNetwork.Client clientOne = new EasyNetwork.Client("tcp://localhost:1982");
            EasyNetwork.Client clientTwo = new EasyNetwork.Client("tcp://localhost:1982");

            // Set up event handler on server
            serverObjectsReceived.Clear();
            server.DataReceived += Server_DataReceived;

            // Build up some objects to send
            MyTestObject obj = new MyTestObject();
            obj.Value = 3.14159f;
            obj.Text = "Hello World!";

            OtherTestObject obj2 = new OtherTestObject();
            obj2.Value = 1234;
            obj2.Text = "Hello World Again!";

            server.Start();
            clientOne.Start();
            clientTwo.Start();

            clientOne.Send<MyTestObject>(obj);
            clientTwo.Send<OtherTestObject>(obj2);

            // Wait for both objects to arrive at server
            while (serverObjectsReceived.Count < 2)
            {
                Thread.Sleep(100);
            }

            Assert.AreEqual(2, serverObjectsReceived.Count);

            Assert.IsTrue(serverObjectsReceived[0].Item1 is MyTestObject);
            MyTestObject actualObjectOne = serverObjectsReceived[0].Item1 as MyTestObject;
            Assert.AreEqual(clientOne.Id, serverObjectsReceived[0].Item2);
            Assert.AreEqual(obj.Value, actualObjectOne.Value);
            Assert.AreEqual(obj.Text, actualObjectOne.Text);

            Assert.IsTrue(serverObjectsReceived[1].Item1 is OtherTestObject);
            OtherTestObject actualObjectTwo = serverObjectsReceived[1].Item1 as OtherTestObject;
            Assert.AreEqual(clientTwo.Id, serverObjectsReceived[1].Item2);
            Assert.AreEqual(obj2.Value, actualObjectTwo.Value);
            Assert.AreEqual(obj2.Text, actualObjectTwo.Text);

            server.Stop();
            clientOne.Stop();
            clientTwo.Stop();       
        }

        /// <summary>
        /// Verifies that the server can respond to requests from multiple clients
        /// </summary>
        [TestMethod]
        public void ServerResponseEventHandlers()
        {
            EasyNetwork.Server server = new EasyNetwork.Server("tcp://*:1982");
            EasyNetwork.Client clientOne = new EasyNetwork.Client("tcp://localhost:1982");
            EasyNetwork.Client clientTwo = new EasyNetwork.Client("tcp://localhost:1982");

            // Set up event handles
            serverObjectsReceived.Clear();
            server.DataReceived += Server_DataReceived;
            clientOneDataReceived = null;
            clientTwoDataReceived = null;
            clientOne.DataReceived += ClientOne_DataReceived;
            clientTwo.DataReceived += ClientTwo_DataReceived;

            server.Start();
            clientOne.Start();
            clientTwo.Start();

            // Build and send a message to the server
            MyTestObject clientOneMessage = new MyTestObject();
            clientOneMessage.Value = 3.14159f;
            clientOneMessage.Text = "Hello Server!";
            clientOne.Send<MyTestObject>(clientOneMessage);

            // Server receives, handles, and responds to message
            while (serverObjectsReceived.Count == 0)
            {
                Thread.Sleep(100);
            }

            Assert.IsTrue(serverObjectsReceived.Count > 0);
            Assert.IsTrue(serverObjectsReceived[0].Item1 is MyTestObject);
            MyTestObject receivedMessage = serverObjectsReceived[0].Item1 as MyTestObject;
            MyTestObject responseMessage = new MyTestObject();
            responseMessage.Value = receivedMessage.Value * 2;
            responseMessage.Text = "Howdy client!";
            server.Send<MyTestObject>(receivedMessage, serverObjectsReceived[0].Item2);

            Thread.Sleep(1000);

            // Make sure the second client didn't receive anything
            Assert.IsNull(clientTwoDataReceived);

            // The clientOne should have received the message destined for it
            Assert.IsNotNull(clientOneDataReceived);
            Assert.IsTrue(clientOneDataReceived is MyTestObject);

            server.Stop();
            clientOne.Stop();
            clientTwo.Stop();
        }

        /// <summary>
        /// Tests that the server maintains a list of clients and that it can actively push to all of them
        /// </summary>
        [TestMethod]
        public void PushToAllClients()
        {            
            EasyNetwork.Server server = new EasyNetwork.Server("tcp://*:1982");
            server.DataReceived += Server_DataReceived;

            List<EasyNetwork.Client> clients = new List<EasyNetwork.Client>();
            const int NumClients = 10;

            for (int i = 0; i < NumClients; i++)
            {
                clients.Add(new EasyNetwork.Client("tcp://localhost:1982"));
                clients[clients.Count - 1].DataReceived += Clients_DataReceived;
            }

            server.Start();
            
            foreach (EasyNetwork.Client client in clients)
            {
                client.Start();
            }

            // Clients are registered with server after any messaging, so send something from each
            MyTestObject helloFromClient = new MyTestObject();
            helloFromClient.Value = 42.42f;
            helloFromClient.Text = "Hello Server!";

            foreach (EasyNetwork.Client client in clients)
            {
                client.Send<MyTestObject>(helloFromClient);
            }

            // Server should keep track of each client after hearing from them
            while (server.ClientList.Count < NumClients)
            {
                Thread.Sleep(100);
            }

            Assert.AreEqual(NumClients, server.ClientList.Count);

            // Send something to each client
            foreach (Guid clientId in server.ClientList)
            {
                MyTestObject helloFromServer = new MyTestObject();
                helloFromServer.Value = 4.2f;
                helloFromServer.Text = clientId.ToString();
                server.Send<MyTestObject>(helloFromServer, clientId);
            }

            // Wait until the appropriate number of responses are received by clients
            while (dataReceivedPerClient.Count < NumClients)
            {
                Thread.Sleep(100);
            }

            // Make sure each client has received their personalized messages from the server
            foreach (EasyNetwork.Client client in clients)
            {
                Object genericObject = dataReceivedPerClient[client.Id];
                Assert.IsNotNull(genericObject);

                if (genericObject is MyTestObject)
                {
                    MyTestObject receivedObject = genericObject as MyTestObject;
                    Assert.AreEqual(client.Id.ToString(), receivedObject.Text);
                }
            }

            server.Stop();

            foreach (EasyNetwork.Client client in clients)
            {
                client.Stop();
            }
        }

        /// <summary>
        /// Event handler for the server receiving objects from clients which just adds them to an accessible list
        /// </summary>
        /// <param name="receivedObject">Object received from client</param>
        /// <param name="clientId">Client ID of client who sent the object</param>
        private void Server_DataReceived(object receivedObject, Guid clientId)
        {
            serverObjectsReceived.Add(new Tuple<Object, Guid>(receivedObject, clientId));
        }

        /// <summary>
        /// Handler for the DataReceived event for client one
        /// </summary>
        /// <param name="receivedObject">The object received from the server</param>
        private void ClientOne_DataReceived(Object receivedObject)
        {
            clientOneDataReceived = receivedObject;
        }

        /// <summary>
        /// Handler for the DataReceived event for client two
        /// </summary>
        /// <param name="receivedObject">The object received from the server</param>
        private void ClientTwo_DataReceived(Object receivedObject)
        {
            clientTwoDataReceived = receivedObject;
        }

        /// <summary>
        /// Event handler for receiving data for each client
        /// </summary>
        /// <param name="receivedObject">Received object from server</param>
        private void Clients_DataReceived(object receivedObject)
        {
            if (receivedObject is MyTestObject)
            {
                MyTestObject serverMsg = receivedObject as MyTestObject;
                dataReceivedPerClient.Add(new Guid(serverMsg.Text), serverMsg);
            }
        }

        /// <summary>
        /// Object used to test passing objects between client and server
        /// </summary>
        private class MyTestObject
        {
            /// <summary> Gets or sets the value of Value </summary>
            public float Value { get; set; }

            /// <summary> Gets or sets the value of Text </summary>
            public string Text { get; set; }
        }

        /// <summary>
        /// Object used to test passing objects between client and server
        /// </summary>
        private class OtherTestObject
        {
            /// <summary> Gets or sets the value of Value </summary>
            public int Value { get; set; }

            /// <summary> Gets or sets the value of Text </summary>
            public string Text { get; set; }
        }
    }
}
