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
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void registerButton_Click(object sender, EventArgs e)
        {
            var registrResul = Authorize.RegisterClient(loginTextBox.Text, passwordTextBox.Text, out string message);

            if (registrResul)
            {
                MessageBox.Show("Успех!");
                Close(); 
            }
            else
            if (message != string.Empty)
                MessageBox.Show("Ошибка регистрации", message);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close(); 
        }
    }
}
