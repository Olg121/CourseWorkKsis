using System;
using System.Collections.Generic;
using System.Text;

namespace SharedGateway
{
    public class AuthData
    {
        public string Login { get; set; } 
        public string Password { get; set; }
    }

    public class AuthDataAnswer
    {
        public enum AuthMessage
        {
            Correct,
            IncorrectPassword,
            AcountNotFound
        }

        public AuthMessage Message { get; set; }
    }

    public class RegistrationAnswer
    {
        public enum RegistrationMessage
        {
            Correct,
            LoginConcerned,
        }

        public RegistrationMessage Message { get; set; }
    }
}
