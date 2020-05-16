namespace Client.Controls
{
    partial class ShowNewsControl
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
            this.menuPanel = new System.Windows.Forms.Panel();
            this.listBoxControl1 = new DevExpress.XtraEditors.ListBoxControl();
            this.refreshButton = new System.Windows.Forms.Button();
            this.newsViewPanel = new System.Windows.Forms.Panel();
            this.newsMemoEditPanel = new System.Windows.Forms.Panel();
            this.newsTextMemoEdit = new DevExpress.XtraEditors.MemoEdit();
            this.newsInfoPanel = new System.Windows.Forms.Panel();
            this.createDateValueLabel = new System.Windows.Forms.Label();
            this.createDateLabel = new System.Windows.Forms.Label();
            this.authorNameValueLabel = new System.Windows.Forms.Label();
            this.authorNameLabel = new System.Windows.Forms.Label();
            this.menuPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).BeginInit();
            this.newsViewPanel.SuspendLayout();
            this.newsMemoEditPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.newsTextMemoEdit.Properties)).BeginInit();
            this.newsInfoPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.listBoxControl1);
            this.menuPanel.Controls.Add(this.refreshButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(167, 563);
            this.menuPanel.TabIndex = 0;
            // 
            // listBoxControl1
            // 
            this.listBoxControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxControl1.Location = new System.Drawing.Point(0, 23);
            this.listBoxControl1.Name = "listBoxControl1";
            this.listBoxControl1.Size = new System.Drawing.Size(167, 540);
            this.listBoxControl1.TabIndex = 1;
            this.listBoxControl1.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // refreshButton
            // 
            this.refreshButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.refreshButton.Location = new System.Drawing.Point(0, 0);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(167, 23);
            this.refreshButton.TabIndex = 0;
            this.refreshButton.Text = "Обновить список";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // newsViewPanel
            // 
            this.newsViewPanel.Controls.Add(this.newsMemoEditPanel);
            this.newsViewPanel.Controls.Add(this.newsInfoPanel);
            this.newsViewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsViewPanel.Location = new System.Drawing.Point(167, 0);
            this.newsViewPanel.Name = "newsViewPanel";
            this.newsViewPanel.Size = new System.Drawing.Size(606, 563);
            this.newsViewPanel.TabIndex = 1;
            // 
            // newsMemoEditPanel
            // 
            this.newsMemoEditPanel.Controls.Add(this.newsTextMemoEdit);
            this.newsMemoEditPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsMemoEditPanel.Location = new System.Drawing.Point(0, 44);
            this.newsMemoEditPanel.Name = "newsMemoEditPanel";
            this.newsMemoEditPanel.Size = new System.Drawing.Size(606, 519);
            this.newsMemoEditPanel.TabIndex = 1;
            // 
            // newsTextMemoEdit
            // 
            this.newsTextMemoEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.newsTextMemoEdit.Location = new System.Drawing.Point(0, 0);
            this.newsTextMemoEdit.Name = "newsTextMemoEdit";
            this.newsTextMemoEdit.Properties.ReadOnly = true;
            this.newsTextMemoEdit.Size = new System.Drawing.Size(606, 519);
            this.newsTextMemoEdit.TabIndex = 0;
            // 
            // newsInfoPanel
            // 
            this.newsInfoPanel.Controls.Add(this.createDateValueLabel);
            this.newsInfoPanel.Controls.Add(this.createDateLabel);
            this.newsInfoPanel.Controls.Add(this.authorNameValueLabel);
            this.newsInfoPanel.Controls.Add(this.authorNameLabel);
            this.newsInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.newsInfoPanel.Location = new System.Drawing.Point(0, 0);
            this.newsInfoPanel.Name = "newsInfoPanel";
            this.newsInfoPanel.Size = new System.Drawing.Size(606, 44);
            this.newsInfoPanel.TabIndex = 0;
            // 
            // createDateValueLabel
            // 
            this.createDateValueLabel.AutoSize = true;
            this.createDateValueLabel.Location = new System.Drawing.Point(180, 10);
            this.createDateValueLabel.Name = "createDateValueLabel";
            this.createDateValueLabel.Size = new System.Drawing.Size(0, 13);
            this.createDateValueLabel.TabIndex = 3;
            // 
            // createDateLabel
            // 
            this.createDateLabel.AutoSize = true;
            this.createDateLabel.Location = new System.Drawing.Point(91, 10);
            this.createDateLabel.Name = "createDateLabel";
            this.createDateLabel.Size = new System.Drawing.Size(83, 13);
            this.createDateLabel.TabIndex = 2;
            this.createDateLabel.Text = "Дата создания";
            // 
            // authorNameValueLabel
            // 
            this.authorNameValueLabel.AutoSize = true;
            this.authorNameValueLabel.Location = new System.Drawing.Point(50, 10);
            this.authorNameValueLabel.Name = "authorNameValueLabel";
            this.authorNameValueLabel.Size = new System.Drawing.Size(0, 13);
            this.authorNameValueLabel.TabIndex = 1;
            // 
            // authorNameLabel
            // 
            this.authorNameLabel.AutoSize = true;
            this.authorNameLabel.Location = new System.Drawing.Point(6, 10);
            this.authorNameLabel.Name = "authorNameLabel";
            this.authorNameLabel.Size = new System.Drawing.Size(38, 13);
            this.authorNameLabel.TabIndex = 0;
            this.authorNameLabel.Text = "Автор";
            // 
            // ShowNewsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.newsViewPanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "ShowNewsControl";
            this.Size = new System.Drawing.Size(773, 563);
            this.menuPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxControl1)).EndInit();
            this.newsViewPanel.ResumeLayout(false);
            this.newsMemoEditPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.newsTextMemoEdit.Properties)).EndInit();
            this.newsInfoPanel.ResumeLayout(false);
            this.newsInfoPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel menuPanel;
        private DevExpress.XtraEditors.ListBoxControl listBoxControl1;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Panel newsViewPanel;
        private System.Windows.Forms.Panel newsMemoEditPanel;
        private DevExpress.XtraEditors.MemoEdit newsTextMemoEdit;
        private System.Windows.Forms.Panel newsInfoPanel;
        private System.Windows.Forms.Label createDateValueLabel;
        private System.Windows.Forms.Label createDateLabel;
        private System.Windows.Forms.Label authorNameValueLabel;
        private System.Windows.Forms.Label authorNameLabel;
    }
}
