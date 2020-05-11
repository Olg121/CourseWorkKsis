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
            this.panel2 = new System.Windows.Forms.Panel();
            this.showNewsButton = new System.Windows.Forms.Button();
            this.createNewsButton = new System.Windows.Forms.Button();
            this.closeButton = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // currentModePanel
            // 
            this.currentModePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.currentModePanel.Location = new System.Drawing.Point(0, 0);
            this.currentModePanel.Name = "currentModePanel";
            this.currentModePanel.Size = new System.Drawing.Size(896, 497);
            this.currentModePanel.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.createNewsButton);
            this.panel2.Controls.Add(this.showNewsButton);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(122, 497);
            this.panel2.TabIndex = 1;
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
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.closeButton.Location = new System.Drawing.Point(0, 470);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(122, 27);
            this.closeButton.TabIndex = 2;
            this.closeButton.Text = "Выход";
            this.closeButton.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 497);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.currentModePanel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel currentModePanel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button createNewsButton;
        private System.Windows.Forms.Button showNewsButton;
    }
}