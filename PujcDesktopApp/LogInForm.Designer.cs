namespace PujcDesktopApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.loginHeader = new System.Windows.Forms.Label();
            this.userPasswordValue = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.userNameValue = new System.Windows.Forms.TextBox();
            this.userNameLabel = new System.Windows.Forms.Label();
            this.userLoginButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // loginHeader
            // 
            this.loginHeader.AutoSize = true;
            this.loginHeader.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginHeader.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.loginHeader.Location = new System.Drawing.Point(24, 21);
            this.loginHeader.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.loginHeader.Name = "loginHeader";
            this.loginHeader.Size = new System.Drawing.Size(109, 50);
            this.loginHeader.TabIndex = 5;
            this.loginHeader.Text = "Login";
            // 
            // userPasswordValue
            // 
            this.userPasswordValue.Location = new System.Drawing.Point(231, 161);
            this.userPasswordValue.Name = "userPasswordValue";
            this.userPasswordValue.Size = new System.Drawing.Size(200, 35);
            this.userPasswordValue.TabIndex = 29;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.passwordLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.passwordLabel.Location = new System.Drawing.Point(26, 159);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(120, 37);
            this.passwordLabel.TabIndex = 31;
            this.passwordLabel.Text = "Password";
            // 
            // userNameValue
            // 
            this.userNameValue.Location = new System.Drawing.Point(231, 112);
            this.userNameValue.Name = "userNameValue";
            this.userNameValue.Size = new System.Drawing.Size(200, 35);
            this.userNameValue.TabIndex = 28;
            // 
            // userNameLabel
            // 
            this.userNameLabel.AutoSize = true;
            this.userNameLabel.Font = new System.Drawing.Font("Segoe UI Light", 19.75F);
            this.userNameLabel.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.userNameLabel.Location = new System.Drawing.Point(26, 110);
            this.userNameLabel.Name = "userNameLabel";
            this.userNameLabel.Size = new System.Drawing.Size(142, 37);
            this.userNameLabel.TabIndex = 30;
            this.userNameLabel.Text = "User Name";
            // 
            // userLoginButton
            // 
            this.userLoginButton.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.userLoginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.userLoginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.userLoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.userLoginButton.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLoginButton.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.userLoginButton.Location = new System.Drawing.Point(163, 260);
            this.userLoginButton.Name = "userLoginButton";
            this.userLoginButton.Size = new System.Drawing.Size(205, 51);
            this.userLoginButton.TabIndex = 32;
            this.userLoginButton.Text = "LogIn";
            this.userLoginButton.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 354);
            this.Controls.Add(this.userLoginButton);
            this.Controls.Add(this.userPasswordValue);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.userNameValue);
            this.Controls.Add(this.userNameLabel);
            this.Controls.Add(this.loginHeader);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "LoginForm";
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginHeader;
        private System.Windows.Forms.TextBox userPasswordValue;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox userNameValue;
        private System.Windows.Forms.Label userNameLabel;
        private System.Windows.Forms.Button userLoginButton;
    }
}