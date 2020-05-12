using DevExpress.ClipboardSource.SpreadsheetML;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using SharedGateway;
using Newtonsoft;
using Newtonsoft.Json;

namespace Client
{
    public class SocketsExtentions
    {
        public static SocketsExtentions SocketsLogicInstance; 
        private const int port = 5533;
        private const string serverAdress = "127.0.0.1"; 
        
        public Message SendMessage(Message message, out string exceptionMessage)
        {
            exceptionMessage = string.Empty; 
            try
            {
                var client = new TcpClient(serverAdress, port);
                var stream = client.GetStream();
                
                var data = Encoding.Unicode.GetBytes(JsonConvert.SerializeObject(message));
                stream.Write(data, 0, data.Length);

                data = new byte[64]; 
                var builder = new StringBuilder();
                int bytes = 0;

                do
                {
                    bytes = stream.Read(data, 0, data.Length);
                    builder.Append(Encoding.Unicode.GetString(data, 0, bytes));
                }
                while (stream.DataAvailable);

                return JsonConvert.DeserializeObject<Message>(builder.ToString());
            }
            catch (Exception e)
            {
                exceptionMessage = e.Message;
                return null; 
            }         
        }
    }
}
