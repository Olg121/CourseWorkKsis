using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client.Forms
{
    public partial class AuthorizeForm : Form
    {
        public AuthorizeForm()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            var authorizeResult = Authorize.AuthorizeClient(loginTextBox.Text, passwordTextBox.Text, out string message);

            if (authorizeResult)
            {
                Close();
            }
            else
            if (message != string.Empty)
                MessageBox.Show("Ошибка авторизации", message); 
        
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            using(var registrationForm = new RegistrationForm())
            {
                registrationForm.ShowDialog(); 
            }
        }
    }
}
