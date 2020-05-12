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
                        answerMessage = CreateMessageAnswer(Authorize(message), Message.MessageTypeEnum.AuthorizeAnswer);
                    }

                    if (message.MessageType == Message.MessageTypeEnum.Registration)
                    {
                        answerMessage = CreateMessageAnswer(Registration(message), Message.MessageTypeEnum.RegistrationAnswer); 
                    }

                    if (message.MessageType == Message.MessageTypeEnum.GetNewsEntitysLiteList)
                    {
                        answerMessage = CreateMessageAnswer(GetNewsEntityLiteList(), Message.MessageTypeEnum.GetNewsEntitysLiteListAnswer);
                    }

                    if (message.MessageType == Message.MessageTypeEnum.CreateNewsEntity)
                    {
                        answerMessage = CreateMessageAnswer(CreateNewsEntity(message), Message.MessageTypeEnum.CreateNewsEntityAnswer);
                    }

                    if (message.MessageType == Message.MessageTypeEnum.GetNewsEntity)
                    {
                        answerMessage = CreateMessageAnswer(GetNewsEntity(message), Message.MessageTypeEnum.GetNewsEntityAnswer);
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


        private Message CreateMessageAnswer(object message, Message.MessageTypeEnum type)
        {
            return new Message()
            {
                MessageText = JsonConvert.SerializeObject(message),
                MessageType = Message.MessageTypeEnum.RegistrationAnswer
            };
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

        public GetNewsEntitysLiteListAnswer GetNewsEntityLiteList()
        {
            var answer = new GetNewsEntitysLiteListAnswer
            {
                NewsEntityLiteList = ServerData.NewsEntities.Select(x => new NewsEntityLite() { Id = x.Id, Name = x.Name }).ToList()
            };

            return answer;
        }

        public GetNewsEntityAnswer GetNewsEntity(Message message)
        {
            var newsEntityId = JsonConvert.DeserializeObject<GetNewsEntityRequest>(message.MessageText).Id;
            var answer = new GetNewsEntityAnswer
            {
                newsEntity = ServerData.NewsEntities.FirstOrDefault(x => x.Id == newsEntityId)
            };
            return answer; 
        }

        public CreateNewsEntityAnswer CreateNewsEntity(Message message)
        {
            var newsEntity = JsonConvert.DeserializeObject<CreateNewsEntityRequest>(message.MessageText).NewsEntity;
            long id;
            Random random = new Random(); 
            do
            {
                id = random.Next(); 
            } while (ServerData.NewsEntities.Any(x => x.Id == id));

            newsEntity.Id = id; 
            ServerData.NewsEntities.Add(newsEntity);

            return new CreateNewsEntityAnswer(); 
        }
    }
}
