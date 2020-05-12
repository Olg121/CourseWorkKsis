using System;
using System.Collections.Generic;
using System.Text;

namespace SharedGateway
{
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
