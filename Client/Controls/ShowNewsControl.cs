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
using SharedGateway; 


namespace Client.Controls
{
    public partial class ShowNewsControl : DevExpress.XtraEditors.XtraUserControl
    {
        public ShowNewsControl()
        {
            InitializeComponent();
        }

        private void listBoxControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selectedItem = listBoxControl1.SelectedItem as NewsEntityLite;
            var newsEntity = NewsLogicExtentions.GetNewsEntityById(selectedItem.Id);
            SetNews(newsEntity);
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            listBoxControl1.DataSource = NewsLogicExtentions.GetNewsList(); 
        }

        private void SetNews(NewsEntity entity)
        {
            if(entity != null)
            {
                authorNameValueLabel.Text = entity.UserName ?? string.Empty;
                createDateValueLabel.Text = entity.CreateDate.ToString() ?? string.Empty;
                newsTextMemoEdit.Text = entity.Text ?? string.Empty;
            }
        }
    }
}
