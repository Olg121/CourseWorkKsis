using Newtonsoft.Json;
using SharedGateway;
using SharedGateway.Requests;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using static SharedGateway.AuthDataAnswer;

namespace Server
{
    class ServerStarter
    {
        public const int port = 5533;
        public static TcpListener listener;

        static void Main()
        {
            listener = new TcpListener(IPAddress.Parse("127.0.0.1"), port);
            listener.Start();

            while (true)
            {
                var client = listener.AcceptTcpClient();
                var clientObject = new ClientHandler(client); 

                var clientThread = new Thread(new ThreadStart(clientObject.Process));
                clientThread.Start();
            }
        }
    }
}
