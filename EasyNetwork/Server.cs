//-----------------------------------------------------------------------------
// Server.cs Copyright(c) 2015 Jacob Christensen and Bryan Hansen
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
namespace EasyNetwork
{
    using System;
    using System.Collections.Generic;
    using System.Threading;

    using NetMQ;

    /// <summary>
    /// Delegate signature used for setting up DataReceived event
    /// </summary>
    /// <param name="receivedObject">Object received from client</param>
    /// <param name="clientId">ID of the client that sent the object</param>
    public delegate void ClientObjectReceived(Object receivedObject, Guid clientId);

    /// <summary>
    /// Server class which handles connections to any number of Clients
    /// </summary>
    public class Server
    {
        /// <summary> NetMQ socket used for communication with clients </summary>
        private NetMQSocket netMqSocket;

        /// <summary> String defining connection type, address, and port </summary>
        private string serverConnectionString;

        /// <summary> String defining connection type, address, and port </summary>
        private Thread listenerThread = null;

        /// <summary> Flag used to know when to shut down listener thread </summary>
        private bool isDone = false;

        /// <summary> List of all clients who have communicated with this server </summary>
        private List<Guid> clientList = new List<Guid>();

        /// <summary>
        /// Initializes a new instance of the Server class
        /// </summary>
        /// <param name="connectionString">How the server should be set up, to listen on TCP port 7954 to all incoming connections: "tcp://*:7954"</param>
        public Server(string connectionString)
        {
            serverConnectionString = connectionString;
            NetMQContext context = NetMQContext.Create();
            netMqSocket = context.CreateRouterSocket();
            netMqSocket.Bind(serverConnectionString);
        }

        /// <summary> Event triggered each time the client receives an object from the server </summary>
        public event ClientObjectReceived DataReceived;

        /// <summary>
        /// Gets the list of clients
        /// </summary>
        public List<Guid> ClientList
        {
            get { return clientList; }
        }

        /// <summary>
        /// Starts the server
        /// </summary>
        public void Start()
        {
            isDone = false;
            listenerThread = new Thread(new ThreadStart(Listener));
            listenerThread.Start();
        }

        /// <summary>
        /// Stops the server
        /// </summary>
        public void Stop()
        {
            isDone = true;
            listenerThread.Join();

            netMqSocket.Unbind(serverConnectionString);
            netMqSocket.Close();
        }

        /// <summary>
        /// Send an object to a specified client
        /// </summary>
        /// <typeparam name="T">The type of the object being sent</typeparam>
        /// <param name="objectToSend">The object to send to the client</param>
        /// <param name="clientId">ID of the client to whom the object will be sent</param>
        public void Send<T>(T objectToSend, Guid clientId)
        {
            byte[] data = BsonMagic.SerializeObject<T>(objectToSend);

            NetMQMessage msgToSend = new NetMQMessage();
            msgToSend.Append(clientId.ToByteArray());
            msgToSend.AppendEmptyFrame();
            msgToSend.Append(typeof(T).AssemblyQualifiedName);
            msgToSend.Append(data);

            netMqSocket.SendMultipartMessage(msgToSend);
        }

        /// <summary>
        /// Thread which listens for incoming NetMQMessages from clients
        /// </summary>
        private void Listener()
        {            
            while (!isDone)
            {
                NetMQMessage receivedMsg = null;

                if (netMqSocket.TryReceiveMultipartMessage(TimeSpan.FromSeconds(1.0), ref receivedMsg))
                {
                    Guid receivedId = new Guid(receivedMsg[0].ToByteArray());
                    string typeStr = receivedMsg[2].ConvertToString();
                    Type t = Type.GetType(typeStr);

                    System.Reflection.MethodInfo method = typeof(BsonMagic).GetMethod("DeserializeObject");
                    System.Reflection.MethodInfo generic = method.MakeGenericMethod(t);

                    Object[] methodParams = new Object[1] { receivedMsg[3].ToByteArray() };
                    Object receivedObject = generic.Invoke(null, methodParams);

                    // Add to client list if this is first time this ID has been seen
                    if (!clientList.Contains(receivedId))
                    {
                        clientList.Add(receivedId);
                    }

                    // Fire event if configured
                    if (DataReceived != null)
                    {
                        DataReceived(receivedObject, receivedId);
                    }
                    else
                    {
                        throw new ArgumentException("Data was received, but no event handler set!");
                    }
                }
            }
        }
    }
}
