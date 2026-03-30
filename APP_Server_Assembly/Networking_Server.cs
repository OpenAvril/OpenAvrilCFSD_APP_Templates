using System;
using System.Data.Common;
using System.Net;
using System.Net.Sockets;
using System.Threading;
using Valve.Sockets;

namespace OpenAvrilCFSD.ServerAssembly
{
    public class Networking_Server
    {
        static private Address address_SERVER;
        static private Address address_CLIENT;
        static private NetworkingSockets _server_SOCKET;
        static private NetworkingUtils _utils;
        static private uint _listenSocket;
        static private uint _pollGroup;

        public Networking_Server()
        {
  
        }
        public void DeInitialise_networking_Server()
        {
            Valve.Sockets.Library.Deinitialize();
        }
        public void Initialise_networking_Server()
        {
            Valve.Sockets.Library.Initialize();
            _server_SOCKET = new NetworkingSockets();

        }
        public void Thread_IO_Server(byte threadId)
        {
            OpenAvrilCFSD.ServerAssembly.Framework_Server obj = OpenAvrilCFSD.ServerAssembly.Program.Get_framework_Server();
            bool doneOnce = false;
            while (obj.Get_server().Get_execute().Get_execute_Control().Get_flag_isInitialised_ServerShell(obj) == true)
            {
                if (doneOnce == false)
                {
                    doneOnce = true;
                    obj.Get_server().Get_execute().Get_execute_Control().Set_flag_ThreadInitialised(threadId, false);
                }
            }
            while (obj.Get_server().Get_execute().Get_execute_Control().Get_exitApplication() == false)
            {
                NetworkingSockets client = new NetworkingSockets();

                uint connection = 0;

                StatusCallback status = (ref StatusInfo info) =>
                {
                    switch (info.connectionInfo.state)
                    {
                        case ConnectionState.None:
                            break;

                        case ConnectionState.Connected:
                            Console.WriteLine("Client connected to server - ID: " + connection);
                            break;

                        case ConnectionState.ClosedByPeer:
                        case ConnectionState.ProblemDetectedLocally:
                            client.CloseConnection(connection);
                            Console.WriteLine("Client disconnected from server");
                            break;
                    }
                };

                utils.SetStatusCallback(status);

                Address address = new Address();

                address.SetAddress("::1", port);

                connection = client.Connect(ref address);

#if VALVESOCKETS_SPAN
	MessageCallback message = (in NetworkingMessage netMessage) => {
		Console.WriteLine("Message received from server - Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);
	};
#else
                const int maxMessages = 20;

                NetworkingMessage[] netMessages = new NetworkingMessage[maxMessages];
#endif

                while (!Console.KeyAvailable)
                {
                    client.RunCallbacks();

#if VALVESOCKETS_SPAN
		client.ReceiveMessagesOnConnection(connection, message, 20);
#else
                    int netMessagesCount = client.ReceiveMessagesOnConnection(connection, netMessages, maxMessages);

                    if (netMessagesCount > 0)
                    {
                        for (int i = 0; i < netMessagesCount; i++)
                        {
                            ref NetworkingMessage netMessage = ref netMessages[i];

                            Console.WriteLine("Message received from server - Channel ID: " + netMessage.channel + ", Data length: " + netMessage.length);

                            netMessage.Destroy();
                        }
                    }
#endif

                    Thread.Sleep(15);
                }
            }
        }
        public NetworkingUtils Get_utils()
        {
            return _utils;
        }
        public uint Get_pollGroup()
        {
            return _pollGroup;
        }
    }
}
