using Client.Controls;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            currentModePanel.Controls.Add(ShowNewsControl);
        }


        private CreateNewsControl CreateNewsControl { get; set; } = new CreateNewsControl() { Dock = DockStyle.Fill };
        private ShowNewsControl ShowNewsControl { get; set; } = new ShowNewsControl() { Dock = DockStyle.Fill };




        private void showNewsButton_Click(object sender, EventArgs e)
        {
            currentModePanel.Controls.Clear();
            currentModePanel.Controls.Add(ShowNewsControl);
        }

        private void createNewsButton_Click(object sender, EventArgs e)
        {
            currentModePanel.Controls.Clear();
            currentModePanel.Controls.Add(CreateNewsControl); 
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
