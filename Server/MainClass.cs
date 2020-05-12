using Newtonsoft.Json;
using SharedGateway;
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
    class MainClass
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

    public class ClientHandler
    {
        public TcpClient client;
        public ClientHandler(TcpClient tcpClient)
        {
            client = tcpClient;
        }

        public void Process()
        {
            NetworkStream stream = null; 

            try
            {
                stream = client.GetStream();
                byte[] data = new byte[64]; // буфер для получаемых данных
                while (true)
                {
                    // получаем сообщение
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    do
                    {
                        bytes = stream.Read(data, 0, data.Length);
                        builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                    }
                    while (stream.DataAvailable);
                    var message = JsonConvert.DeserializeObject<Message>(builder.ToString());

                    Message answerMessage = null; 

                    if (message.MessageType == Message.MessageTypeEnum.Authorize)
                    {
                        var answer = Authorize(message);
                        answerMessage = new Message()
                        { 
                            MessageText = JsonConvert.SerializeObject(answer),
                            MessageType = Message.MessageTypeEnum.AuthorizeAnswer
                        };
                    }

                    if (message.MessageType == Message.MessageTypeEnum.Registration)
                    {
                        var answer = Registration(message);
                        answerMessage = new Message()
                        {
                            MessageText = JsonConvert.SerializeObject(answer),
                            MessageType = Message.MessageTypeEnum.RegistrationAnswer
                        };
                    }

                    Console.WriteLine(answerMessage.MessageText);

                    data = Encoding.Unicode.GetBytes(JsonConvert.SerializeObject(answerMessage));
                    stream.Write(data, 0, data.Length);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                if (stream != null)
                    stream.Close();
                if (client != null)
                    client.Close();
            }
        }

        public AuthDataAnswer Authorize(Message message)
        {
            var authData = JsonConvert.DeserializeObject<AuthData>(message.MessageText);
            var user = ServerData.Users.FirstOrDefault(x => x.Login == authData.Login);
            var authDataAnswer = new AuthDataAnswer();

            if (user == null)
                authDataAnswer.Message = AuthMessage.AcountNotFound;
            else
            if (user.Password != authData.Password)
                authDataAnswer.Message = AuthMessage.IncorrectPassword;
            else
                authDataAnswer.Message = AuthMessage.Correct;
            return authDataAnswer; 
        }
    
        public RegistrationAnswer Registration(Message message)
        {
            var authData = JsonConvert.DeserializeObject<AuthData>(message.MessageText);
            var user = ServerData.Users.FirstOrDefault(x => x.Login == authData.Login);
            var answer = new RegistrationAnswer();
            if (user == null)
            {
                ServerData.Users.Add(authData);
                answer.Message = RegistrationAnswer.RegistrationMessage.Correct;
            }
            else
                answer.Message = RegistrationAnswer.RegistrationMessage.LoginConcerned; 

            return answer; 
        }

        public List<NewsEntityLite> GetNewsEntityLiteList()
        {
            return ServerData.NewsEntities.Select(x => new NewsEntityLite() { Id = x.Id, Name = x.Name }).ToList();
        }

        public NewsEntity GetNewsEntity(Message message)
        {

            return ServerData.NewsEntities.FirstOrDefault(x => x.Id == 0); 
        }
    }
}
