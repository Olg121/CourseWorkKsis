using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using SharedGateway;
using SharedGateway.Requests;

namespace Client
{
    class NewsExtentions
    {
        public static List<NewsEntityLite> GetNewsList()
        {
            var socketLogic = SocketsExtentions.SocketsLogicInstance;
            var message = new Message { MessageText = "", MessageType = Message.MessageTypeEnum.GetNewsEntitysLiteList };
            
            var answerMessage = socketLogic.SendMessage(message, out _);
            var answer = JsonConvert.DeserializeObject<GetNewsEntitysLiteListAnswer>(answerMessage.MessageText);

            return answer.NewsEntityLiteList; 
        }

        public static NewsEntity GetNewsEntityById(long id)
        {
            var socketLogic = SocketsExtentions.SocketsLogicInstance;
            var request = new GetNewsEntityRequest { Id = id };
            var message = new Message { MessageText = JsonConvert.SerializeObject(request), MessageType = Message.MessageTypeEnum.GetNewsEntity };
            var answerMessage = socketLogic.SendMessage(message, out _);
            var newsEntity = JsonConvert.DeserializeObject<GetNewsEntityAnswer>(answerMessage.MessageText).newsEntity;
            return newsEntity; 
        }

        public static bool CreateNews(string caption, string text, out string exceptionMessage)
        {
            if(string.IsNullOrWhiteSpace(caption) || string.IsNullOrWhiteSpace(text))
            {
                exceptionMessage = "Заполните поля";
                return false;
            }

            var newsEntity = new NewsEntity()
            {
                CreateDate = DateTime.Now,
                UserName = AuthorizeExtentions.UserName,
                Name = caption,
                Text = text
            };

            var socketLogic = SocketsExtentions.SocketsLogicInstance;
            var request = new CreateNewsEntityRequest { NewsEntity = newsEntity };
            var message = new Message { MessageText = JsonConvert.SerializeObject(request), MessageType = Message.MessageTypeEnum.CreateNewsEntity };
            var answerMessage = socketLogic.SendMessage(message, out _);




            exceptionMessage = string.Empty; 
            return true; 
        }

    }
}
