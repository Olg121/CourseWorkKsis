using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SharedGateway;
namespace Client
{
    class NewsExtentions
    {
        public static List<NewsEntityLite> GetNewsList()
        {
            return new List<NewsEntityLite>(); 
        }

        public static NewsEntity GetNewsEntityById(long id)
        {
            return new NewsEntity() { CreateDate = DateTime.Now, Text = string.Empty, Id = 0, Name = "New", UserName = "Oleg" };
        }

        public static bool CreateNews(string caption, string text, out string message)
        {
            if(string.IsNullOrWhiteSpace(caption) || string.IsNullOrWhiteSpace(text))
            {
                message = "Заполните поля";
                return false;
            }

            var newsEntity = new NewsEntity()
            {
                CreateDate = DateTime.Now,
                UserName = AuthorizeExtentions.UserName,
                Name = caption,
                Text = text
            };

            message = string.Empty; 
            return true; 
        }

    }
}
