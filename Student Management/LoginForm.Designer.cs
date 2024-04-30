namespace Student_Management
{
    partial class LoginForm
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
            this.credentialInputGroup = new System.Windows.Forms.GroupBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.passwordInput = new System.Windows.Forms.TextBox();
            this.usernameInput = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.credentialInputGroup.SuspendLayout();
            this.SuspendLayout();
            // 
            // credentialInputGroup
            // 
            this.credentialInputGroup.Controls.Add(this.loginBtn);
            this.credentialInputGroup.Controls.Add(this.passwordInput);
            this.credentialInputGroup.Controls.Add(this.usernameInput);
            this.credentialInputGroup.Location = new System.Drawing.Point(167, 89);
            this.credentialInputGroup.Margin = new System.Windows.Forms.Padding(0);
            this.credentialInputGroup.Name = "credentialInputGroup";
            this.credentialInputGroup.Size = new System.Drawing.Size(443, 243);
            this.credentialInputGroup.TabIndex = 0;
            this.credentialInputGroup.TabStop = false;
            this.credentialInputGroup.Text = "groupBox1";
            // 
            // loginBtn
            // 
            this.loginBtn.Location = new System.Drawing.Point(67, 165);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(75, 23);
            this.loginBtn.TabIndex = 2;
            this.loginBtn.Text = "login";
            this.loginBtn.UseVisualStyleBackColor = true;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // passwordInput
            // 
            this.passwordInput.Location = new System.Drawing.Point(57, 115);
            this.passwordInput.Name = "passwordInput";
            this.passwordInput.PasswordChar = '*';
            this.passwordInput.Size = new System.Drawing.Size(100, 22);
            this.passwordInput.TabIndex = 1;
            // 
            // usernameInput
            // 
            this.usernameInput.Location = new System.Drawing.Point(48, 39);
            this.usernameInput.Name = "usernameInput";
            this.usernameInput.Size = new System.Drawing.Size(100, 22);
            this.usernameInput.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.credentialInputGroup);
            this.Name = "LoginForm";
            this.Text = "Student management";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.credentialInputGroup.ResumeLayout(false);
            this.credentialInputGroup.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox credentialInputGroup;
        private System.Windows.Forms.TextBox passwordInput;
        private System.Windows.Forms.TextBox usernameInput;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.Label label1;
    }
}

