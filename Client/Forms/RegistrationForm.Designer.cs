namespace Client.Forms
{
    partial class RegistrationForm
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
            this.registerButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.loginTextBox = new System.Windows.Forms.TextBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.loginLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerButton
            // 
            this.registerButton.Location = new System.Drawing.Point(173, 154);
            this.registerButton.Name = "registerButton";
            this.registerButton.Size = new System.Drawing.Size(90, 28);
            this.registerButton.TabIndex = 13;
            this.registerButton.Text = "Регистрация";
            this.registerButton.UseVisualStyleBackColor = true;
            this.registerButton.Click += new System.EventHandler(this.registerButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(293, 154);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(90, 28);
            this.cancelButton.TabIndex = 12;
            this.cancelButton.Text = "Отмена";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Location = new System.Drawing.Point(173, 107);
            this.passwordTextBox.MaximumSize = new System.Drawing.Size(210, 30);
            this.passwordTextBox.MinimumSize = new System.Drawing.Size(210, 30);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(210, 20);
            this.passwordTextBox.TabIndex = 11;
            // 
            // loginTextBox
            // 
            this.loginTextBox.Location = new System.Drawing.Point(173, 63);
            this.loginTextBox.MaximumSize = new System.Drawing.Size(210, 30);
            this.loginTextBox.MinimumSize = new System.Drawing.Size(210, 30);
            this.loginTextBox.Name = "loginTextBox";
            this.loginTextBox.Size = new System.Drawing.Size(210, 20);
            this.loginTextBox.TabIndex = 10;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.registerLabel.Location = new System.Drawing.Point(190, 20);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(170, 29);
            this.registerLabel.TabIndex = 9;
            this.registerLabel.Text = "Регистрация";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold);
            this.passwordLabel.Location = new System.Drawing.Point(65, 108);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(102, 29);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Пароль";
            // 
            // loginLabel
            // 
            this.loginLabel.AutoSize = true;
            this.loginLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.25F, System.Drawing.FontStyle.Bold);
            this.loginLabel.Location = new System.Drawing.Point(80, 64);
            this.loginLabel.Name = "loginLabel";
            this.loginLabel.Size = new System.Drawing.Size(87, 29);
            this.loginLabel.TabIndex = 7;
            this.loginLabel.Text = "Логин";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 211);
            this.Controls.Add(this.registerButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.passwordTextBox);
            this.Controls.Add(this.loginTextBox);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.loginLabel);
            this.Name = "RegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "RegistrationForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button registerButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox loginTextBox;
        private System.Windows.Forms.Label registerLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label loginLabel;
    }
}