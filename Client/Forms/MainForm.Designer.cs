namespace Client.Forms
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.currentModePanel = new System.Windows.Forms.Panel();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.Button();
            this.createNewsButton = new System.Windows.Forms.Button();
            this.showNewsButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentModePanel
            // 
            this.currentModePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentModePanel.Location = new System.Drawing.Point(122, 0);
            this.currentModePanel.Name = "currentModePanel";
            this.currentModePanel.Size = new System.Drawing.Size(926, 700);
            this.currentModePanel.TabIndex = 0;
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.closeButton);
            this.menuPanel.Controls.Add(this.createNewsButton);
            this.menuPanel.Controls.Add(this.showNewsButton);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(122, 700);
            this.menuPanel.TabIndex = 1;
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeButton.Location = new System.Drawing.Point(0, 673);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(122, 27);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // createNewsButton
            // 
            this.createNewsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.createNewsButton.Location = new System.Drawing.Point(0, 27);
            this.createNewsButton.Name = "createNewsButton";
            this.createNewsButton.Size = new System.Drawing.Size(122, 27);
            this.createNewsButton.TabIndex = 1;
            this.createNewsButton.Text = "Создать новость";
            this.createNewsButton.UseVisualStyleBackColor = true;
            this.createNewsButton.Click += new System.EventHandler(this.createNewsButton_Click);
            // 
            // showNewsButton
            // 
            this.showNewsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.showNewsButton.Location = new System.Drawing.Point(0, 0);
            this.showNewsButton.Name = "showNewsButton";
            this.showNewsButton.Size = new System.Drawing.Size(122, 27);
            this.showNewsButton.TabIndex = 0;
            this.showNewsButton.Text = "Показать новости";
            this.showNewsButton.UseVisualStyleBackColor = true;
            this.showNewsButton.Click += new System.EventHandler(this.showNewsButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1048, 700);
            this.Controls.Add(this.currentModePanel);
            this.Controls.Add(this.menuPanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "MainForm";
            this.menuPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel currentModePanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button createNewsButton;
        private System.Windows.Forms.Button showNewsButton;
    }
}