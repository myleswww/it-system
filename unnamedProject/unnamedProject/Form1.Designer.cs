namespace unnamedProject
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
            this.labelLogin = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.signIn = new System.Windows.Forms.Button();
            this.errorIncorrect = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(211, 31);
            this.labelLogin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(51, 17);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "LOGIN";
            this.labelLogin.Click += new System.EventHandler(this.label1_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.Location = new System.Drawing.Point(85, 138);
            this.passwordBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(312, 22);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Location = new System.Drawing.Point(85, 75);
            this.usernameBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(312, 22);
            this.usernameBox.TabIndex = 4;
            this.usernameBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(85, 52);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(73, 17);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.label2_Click);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(85, 118);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(69, 17);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            this.labelPassword.Click += new System.EventHandler(this.label3_Click);
            // 
            // signIn
            // 
            this.signIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signIn.Location = new System.Drawing.Point(187, 178);
            this.signIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(100, 28);
            this.signIn.TabIndex = 7;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorIncorrect
            // 
            this.errorIncorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorIncorrect.AutoSize = true;
            this.errorIncorrect.ForeColor = System.Drawing.Color.Red;
            this.errorIncorrect.Location = new System.Drawing.Point(64, 5);
            this.errorIncorrect.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.errorIncorrect.Name = "errorIncorrect";
            this.errorIncorrect.Size = new System.Drawing.Size(352, 17);
            this.errorIncorrect.TabIndex = 12;
            this.errorIncorrect.Text = "ERROR: USERNAME OR PASSWORD IS INCORRECT";
            this.errorIncorrect.Visible = false;
            this.errorIncorrect.Click += new System.EventHandler(this.label6_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(495, 226);
            this.Controls.Add(this.errorIncorrect);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.labelLogin);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinimumSize = new System.Drawing.Size(510, 264);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "w";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Button signIn;
        private System.Windows.Forms.Label errorIncorrect;
    }
}

