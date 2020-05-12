using System;
using System.Collections.Generic;
using System.Text;

namespace SharedGateway
{
    public class Message
    {
        public string MessageText { get; set; }
        public enum MessageTypeEnum
        {
            Authorize,
            AuthorizeAnswer
        }
        public MessageTypeEnum MessageType {get; set; }
    }
}
