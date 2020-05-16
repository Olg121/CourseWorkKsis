namespace Client.Controls
{
    partial class CreateNewsControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControlPanel = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.sendNewsButton = new System.Windows.Forms.Button();
            this.newsNamePanel = new System.Windows.Forms.Panel();
            this.textMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.dockPanelPanel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.captionTextBox = new System.Windows.Forms.TextBox();
            this.panelViewControlPanel = new System.Windows.Forms.Panel();
            this.newsCaptionPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panelControlPanel.SuspendLayout();
            this.newsNamePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textMemoEdit.Properties)).BeginInit();
            this.dockPanelPanel1.SuspendLayout();
            this.panelViewControlPanel.SuspendLayout();
            this.newsCaptionPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControlPanel
            // 
            this.panelControlPanel.Controls.Add(this.panel1);
            this.panelControlPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControlPanel.Location = new System.Drawing.Point(0, 549);
            this.panelControlPanel.Name = "panelControlPanel";
            this.panelControlPanel.Size = new System.Drawing.Size(891, 43);
            this.panelControlPanel.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 34);
            this.button1.TabIndex = 2;
            this.button1.Text = "Очистить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // sendNewsButton
            // 
            this.sendNewsButton.Location = new System.Drawing.Point(104, 4);
            this.sendNewsButton.Name = "sendNewsButton";
            this.sendNewsButton.Size = new System.Drawing.Size(83, 34);
            this.sendNewsButton.TabIndex = 3;
            this.sendNewsButton.Text = "Отправить новость";
            this.sendNewsButton.UseVisualStyleBackColor = true;
            this.sendNewsButton.Click += new System.EventHandler(this.sendNewsButton_Click);
            // 
            // newsNamePanel
            // 
            this.newsNamePanel.Controls.Add(this.textMemoEdit);
            this.newsNamePanel.Controls.Add(this.dockPanelPanel1);
            this.newsNamePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsNamePanel.Location = new System.Drawing.Point(0, 50);
            this.newsNamePanel.Name = "newsNamePanel";
            this.newsNamePanel.Size = new System.Drawing.Size(891, 499);
            this.newsNamePanel.TabIndex = 1;
            // 
            // textMemoEdit
            // 
            this.textMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textMemoEdit.Location = new System.Drawing.Point(0, 21);
            this.textMemoEdit.Name = "textMemoEdit";
            this.textMemoEdit.Size = new System.Drawing.Size(891, 478);
            this.textMemoEdit.TabIndex = 1;
            // 
            // dockPanelPanel1
            // 
            this.dockPanelPanel1.Controls.Add(this.label2);
            this.dockPanelPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dockPanelPanel1.Location = new System.Drawing.Point(0, 0);
            this.dockPanelPanel1.Name = "dockPanelPanel1";
            this.dockPanelPanel1.Size = new System.Drawing.Size(891, 21);
            this.dockPanelPanel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(394, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Содержание";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(410, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Тема";
            // 
            // captionTextBox
            // 
            this.captionTextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.captionTextBox.Location = new System.Drawing.Point(0, 29);
            this.captionTextBox.Name = "captionTextBox";
            this.captionTextBox.Size = new System.Drawing.Size(891, 21);
            this.captionTextBox.TabIndex = 1;
            // 
            // panelViewControlPanel
            // 
            this.panelViewControlPanel.Controls.Add(this.newsNamePanel);
            this.panelViewControlPanel.Controls.Add(this.newsCaptionPanel);
            this.panelViewControlPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelViewControlPanel.Location = new System.Drawing.Point(0, 0);
            this.panelViewControlPanel.Name = "panelViewControlPanel";
            this.panelViewControlPanel.Size = new System.Drawing.Size(891, 549);
            this.panelViewControlPanel.TabIndex = 1;
            // 
            // newsCaptionPanel
            // 
            this.newsCaptionPanel.Controls.Add(this.captionTextBox);
            this.newsCaptionPanel.Controls.Add(this.label1);
            this.newsCaptionPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newsCaptionPanel.Location = new System.Drawing.Point(0, 0);
            this.newsCaptionPanel.Name = "newsCaptionPanel";
            this.newsCaptionPanel.Size = new System.Drawing.Size(891, 50);
            this.newsCaptionPanel.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.sendNewsButton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(702, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(189, 43);
            this.panel1.TabIndex = 4;
            // 
            // CreateNewsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelViewControlPanel);
            this.Controls.Add(this.panelControlPanel);
            this.Name = "CreateNewsControl";
            this.Size = new System.Drawing.Size(891, 592);
            this.panelControlPanel.ResumeLayout(false);
            this.newsNamePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textMemoEdit.Properties)).EndInit();
            this.dockPanelPanel1.ResumeLayout(false);
            this.dockPanelPanel1.PerformLayout();
            this.panelViewControlPanel.ResumeLayout(false);
            this.newsCaptionPanel.ResumeLayout(false);
            this.newsCaptionPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlPanel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button sendNewsButton;
        private System.Windows.Forms.TextBox captionTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel newsNamePanel;
        private DevExpress.XtraEditors.MemoEdit textMemoEdit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel dockPanelPanel1;
        private System.Windows.Forms.Panel panelViewControlPanel;
        private System.Windows.Forms.Panel newsCaptionPanel;
        private System.Windows.Forms.Panel panel1;
    }
}
