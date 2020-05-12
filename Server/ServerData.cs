using SharedGateway;
using System;
using System.Collections.Generic;
using System.Text;

namespace Server
{
    public static class ServerData
    {
        public static List<AuthData> Users { get; set; } = new List<AuthData>
        {
            new AuthData { Login = "Login", Password = "Password"}
        };
        public static List<NewsEntity> NewsEntities { get; set; } = new List<NewsEntity>
        {
            new NewsEntity()
            {
                CreateDate = DateTime.Now, Id = 0, Name = "Login news", Text = "My first news", UserName = "Login"
            }
        };


    }
}
