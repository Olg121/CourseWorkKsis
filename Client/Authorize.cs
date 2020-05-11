using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    class Authorize
    {
        public static bool Authorized { get; set; } = false;
        public static string UserName { get; set; } = string.Empty; 



        public static bool AuthorizeClient(string login, string password, out string errorMessage)
        {
            errorMessage = "";
            UserName = login; 
            return Authorized = true; 
        }

        public static bool RegisterClient(string login, string password, out string errorMessage)
        {
            errorMessage = ""; 
            return true; 
        }


    }
}
