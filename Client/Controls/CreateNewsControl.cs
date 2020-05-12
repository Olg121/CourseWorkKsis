using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Client.Controls
{
    public partial class CreateNewsControl : DevExpress.XtraEditors.XtraUserControl
    {
        public CreateNewsControl()
        {
            InitializeComponent();
        }

        private void sendNewsButton_Click(object sender, EventArgs e)
        {
            var sendResult = NewsExtentions.CreateNews(captionTextBox.Text, textMemoEdit.Text, out string errorMessage);

            if (sendResult)
            {
                Clear();
                MessageBox.Show("Успех");
            }
            else
                MessageBox.Show(errorMessage, "Ошибка");
        }

        private void Clear()
        {
            captionTextBox.Text = string.Empty;
            textMemoEdit.Text = string.Empty;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Clear();
        }
    }
}
