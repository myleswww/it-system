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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.labelLogin = new System.Windows.Forms.Label();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.labelUsername = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.signIn = new System.Windows.Forms.Button();
            this.errorIncorrect = new System.Windows.Forms.Label();
            this.exitBtn = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.logoList = new System.Windows.Forms.ImageList(this.components);
            this.logo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLogin.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelLogin.Location = new System.Drawing.Point(245, 91);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(51, 17);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "LOGIN";
            // 
            // passwordBox
            // 
            this.passwordBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.passwordBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.passwordBox.Location = new System.Drawing.Point(154, 182);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '•';
            this.passwordBox.Size = new System.Drawing.Size(250, 20);
            this.passwordBox.TabIndex = 2;
            // 
            // usernameBox
            // 
            this.usernameBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameBox.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameBox.Location = new System.Drawing.Point(154, 131);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(250, 19);
            this.usernameBox.TabIndex = 1;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.labelUsername.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelUsername.Location = new System.Drawing.Point(155, 110);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(69, 16);
            this.labelUsername.TabIndex = 5;
            this.labelUsername.Text = "Username";
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Britannic Bold", 10F);
            this.labelPassword.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelPassword.Location = new System.Drawing.Point(155, 161);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(68, 16);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password";
            // 
            // signIn
            // 
            this.signIn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.signIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signIn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.signIn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.signIn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signIn.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signIn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.signIn.Location = new System.Drawing.Point(235, 214);
            this.signIn.Name = "signIn";
            this.signIn.Size = new System.Drawing.Size(80, 22);
            this.signIn.TabIndex = 3;
            this.signIn.Text = "Sign In";
            this.signIn.UseVisualStyleBackColor = true;
            this.signIn.Click += new System.EventHandler(this.button1_Click);
            // 
            // errorIncorrect
            // 
            this.errorIncorrect.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.errorIncorrect.AutoSize = true;
            this.errorIncorrect.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorIncorrect.ForeColor = System.Drawing.Color.Red;
            this.errorIncorrect.Location = new System.Drawing.Point(154, 78);
            this.errorIncorrect.Name = "errorIncorrect";
            this.errorIncorrect.Size = new System.Drawing.Size(245, 12);
            this.errorIncorrect.TabIndex = 12;
            this.errorIncorrect.Text = "ERROR: USERNAME OR PASSWORD IS INCORRECT";
            this.errorIncorrect.Visible = false;
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Location = new System.Drawing.Point(526, 7);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(34, 26);
            this.exitBtn.TabIndex = 6;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimizeBtn.Location = new System.Drawing.Point(504, 7);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(19, 26);
            this.minimizeBtn.TabIndex = 4;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // logoList
            // 
            this.logoList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("logoList.ImageStream")));
            this.logoList.TransparentColor = System.Drawing.Color.Transparent;
            this.logoList.Images.SetKeyName(0, "iconfinder_ArtificialIntelligence12_2890565.ico");
            this.logoList.Images.SetKeyName(1, "iconfinder_ArtificialIntelligence7_2890571.ico");
            this.logoList.Images.SetKeyName(2, "brain (1).png");
            this.logoList.Images.SetKeyName(3, "brain.png");
            this.logoList.Images.SetKeyName(4, "chatbot.png");
            this.logoList.Images.SetKeyName(5, "toilet.png");
            this.logoList.Images.SetKeyName(6, "artificial-intelligence (5).png");
            this.logoList.Images.SetKeyName(7, "artificial-intelligence (5)-1.png");
            // 
            // logo
            // 
            this.logo.FlatAppearance.BorderSize = 0;
            this.logo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.logo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.logo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logo.ImageIndex = 7;
            this.logo.ImageList = this.logoList;
            this.logo.Location = new System.Drawing.Point(10, 10);
            this.logo.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.logo.Name = "logo";
            this.logo.Size = new System.Drawing.Size(89, 82);
            this.logo.TabIndex = 16;
            this.logo.TabStop = false;
            this.logo.UseVisualStyleBackColor = true;
            // 
            // LoginForm
            // 
            this.AcceptButton = this.signIn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(567, 323);
            this.Controls.Add(this.logo);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.errorIncorrect);
            this.Controls.Add(this.signIn);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.labelUsername);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.labelLogin);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(408, 211);
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
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
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.ImageList logoList;
        private System.Windows.Forms.Button logo;
    }
}

