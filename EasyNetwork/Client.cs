//-----------------------------------------------------------------------------
// Client.cs Copyright(c) 2015 Jacob Christensen and Bryan Hansen
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
    using System.Threading;

    using NetMQ;

    /// <summary>
    /// Delegate signature used for setting up DataReceived event
    /// </summary>
    /// <param name="receivedObject">The object received from the server</param>
    public delegate void ObjectReceived(Object receivedObject);

    /// <summary>
    /// Client class which can send and receive objects to/from a Server
    /// </summary>
    public class Client
    {
        /// <summary> Socket used for communicating with the Server </summary>
        private NetMQSocket clientSocket;

        /// <summary> String defining connection type, address, and port </summary>
        private string clientConnectionString;

        /// <summary> Thread which listens for incoming data from the Server </summary>
        private Thread listenerThread = null;

        /// <summary> Flag used to know when to shut down listener thread </summary>
        private bool isDone = false;

        /// <summary>
        /// Initializes a new instance of the Client class
        /// </summary>
        /// <param name="connectionString">How the server should be set up, to listen on TCP port 7954 to all incoming connections: "tcp://172.154.231.18:7954"</param>
        public Client(string connectionString)
        {
            Id = Guid.NewGuid(); // Generate an ID for this client

            NetMQContext context = NetMQContext.Create();
            clientConnectionString = connectionString;
            clientSocket = context.CreateDealerSocket();
            clientSocket.Options.Identity = Id.ToByteArray();
            clientSocket.Connect(clientConnectionString);                    
        }

        /// <summary> Event triggered each time the client receives an object from the server </summary>
        public event ObjectReceived DataReceived;

        /// <summary> Gets this client's ID </summary>
        public Guid Id { get; private set; }

        /// <summary>
        /// Starts the Client
        /// </summary>
        public void Start()
        {
            isDone = false;
            listenerThread = new Thread(new ThreadStart(Listener));
            listenerThread.Start();
        }

        /// <summary>
        /// Stops the Client
        /// </summary>
        public void Stop()
        {
            isDone = true;
            listenerThread.Join();

            clientSocket.Disconnect(clientConnectionString);
            clientSocket.Close();
        }

        /// <summary>
        /// Sends an object to the Server
        /// </summary>
        /// <typeparam name="T">Type of object to be sent</typeparam>
        /// <param name="objectToSend">The object to send to the server</param>
        public void Send<T>(T objectToSend)
        {
            byte[] data = BsonMagic.SerializeObject<T>(objectToSend);
            NetMQMessage messageToServer = new NetMQMessage();

            messageToServer.AppendEmptyFrame();        
            messageToServer.Append(typeof(T).AssemblyQualifiedName);
            messageToServer.Append(data);

            clientSocket.SendMultipartMessage(messageToServer);            
        }

        /// <summary>
        /// Thread which listens for incoming NetMQMessages from the server and queues them up for handling
        /// </summary>
        private void Listener()
        {
            while (!isDone)
            {
                NetMQMessage message = null;                

                if (clientSocket.TryReceiveMultipartMessage(TimeSpan.FromSeconds(1.0), ref message))
                {
                    string typeStr = message[1].ConvertToString();
                    Type objectType = Type.GetType(typeStr);

                    System.Reflection.MethodInfo method = typeof(BsonMagic).GetMethod("DeserializeObject");
                    System.Reflection.MethodInfo generic = method.MakeGenericMethod(objectType);

                    Object[] methodParams = new Object[1] { message[2].ToByteArray() };

                    Object receivedObject = generic.Invoke(null, methodParams);

                    if (DataReceived != null)
                    {
                        DataReceived(receivedObject);
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
