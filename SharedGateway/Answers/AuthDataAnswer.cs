using System;
using System.Collections.Generic;
using System.Text;

namespace SharedGateway
{
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
}
