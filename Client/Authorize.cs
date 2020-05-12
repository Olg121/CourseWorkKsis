using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedGateway;
using Newtonsoft;
using Newtonsoft.Json;
using DevExpress.Utils.IoC;

namespace Client
{
    class Authorize
    {
        public static bool Authorized { get; set; } = false;
        public static string UserName { get; set; } = string.Empty; 

        public SocketsLogic SocketsLogic { get; set; }


        public static bool AuthorizeClient(string login, string password, out string errorMessage)
        {
            var socketLogic = SocketsLogic.SocketsLogicInstance; 
            var authData = new AuthData { Login = login, Password = password };
            var message = new Message { MessageText = JsonConvert.SerializeObject(authData), MessageType = Message.MessageTypeEnum.Authorize };
            
            var answerMessage = socketLogic.SendMessage(message, out errorMessage);
            var authDataAnswer = JsonConvert.DeserializeObject<AuthDataAnswer>(answerMessage.MessageText);
            if (authDataAnswer.Message == AuthDataAnswer.AuthMessage.Correct)
            {
                UserName = login;
                return Authorized = true;
            }
            else if (authDataAnswer.Message == AuthDataAnswer.AuthMessage.IncorrectPassword)
                errorMessage = "Не правильный пароль";
            else if (authDataAnswer.Message == AuthDataAnswer.AuthMessage.AcountNotFound)
                errorMessage = "Акаунт не зарегистрирован"; 
            
        
            return Authorized = false; 
        }

        public static bool RegisterClient(string login, string password, out string errorMessage)
        {
            errorMessage = "";
            var socketLogic = SocketsLogic.SocketsLogicInstance;
            var authData = new AuthData 
            { 
                Login = login, 
                Password = password 
            };
            var message = new Message 
            {
                MessageText = JsonConvert.SerializeObject(authData),
                MessageType = Message.MessageTypeEnum.Registration 
            };            


            var answerMessage = socketLogic.SendMessage(message, out errorMessage);

            var authDataAnswer = JsonConvert.DeserializeObject<RegistrationAnswer>(answerMessage.MessageText);
            if (authDataAnswer.Message == RegistrationAnswer.RegistrationMessage.Correct)
                return true;

            errorMessage = "Пользователь с таким логином уже существует"; 
            return false; 
        }


    }
}
