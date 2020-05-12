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
            AuthorizeAnswer,
            Registration,
            RegistrationAnswer,
            GetNewsEntitysLiteList,
            GetNewsEntity,
            CreateNewsEntity
        }
        public MessageTypeEnum MessageType {get; set; }
    }
}
