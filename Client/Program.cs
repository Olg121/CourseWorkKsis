using Client.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            SocketsExtentions.SocketsLogicInstance = new SocketsExtentions(); 
            using (var authorizeForm = new AuthorizeForm())
            {
                authorizeForm.ShowDialog();
                if (authorizeForm.DialogResult == DialogResult.OK)
                    Application.Run(new MainForm());
            }      
        }
    }
}
