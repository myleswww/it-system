namespace unnamedProject
{
    partial class register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(register));
            this.username = new System.Windows.Forms.TextBox();
            this.password = new System.Windows.Forms.TextBox();
            this.email = new System.Windows.Forms.TextBox();
            this.firstName = new System.Windows.Forms.TextBox();
            this.lastName = new System.Windows.Forms.TextBox();
            this.confirm = new System.Windows.Forms.TextBox();
            this.UsernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.emailLabel = new System.Windows.Forms.Label();
            this.firstnameLabel = new System.Windows.Forms.Label();
            this.lastnameLabel = new System.Windows.Forms.Label();
            this.levelAccessLabel = new System.Windows.Forms.Label();
            this.submit = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.backButtonList = new System.Windows.Forms.ImageList(this.components);
            this.ast1 = new System.Windows.Forms.Label();
            this.passAst = new System.Windows.Forms.Label();
            this.conPassAst = new System.Windows.Forms.Label();
            this.fNameAst = new System.Windows.Forms.Label();
            this.lNameAst = new System.Windows.Forms.Label();
            this.eAst = new System.Windows.Forms.Label();
            this.accessAst = new System.Windows.Forms.Label();
            this.roleCombo = new System.Windows.Forms.ComboBox();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // username
            // 
            this.username.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.username.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.username.Location = new System.Drawing.Point(134, 122);
            this.username.Margin = new System.Windows.Forms.Padding(4);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(132, 22);
            this.username.TabIndex = 0;
            this.username.TextChanged += new System.EventHandler(this.username_TextChanged);
            // 
            // password
            // 
            this.password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.password.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.password.Location = new System.Drawing.Point(133, 188);
            this.password.Margin = new System.Windows.Forms.Padding(4);
            this.password.Name = "password";
            this.password.PasswordChar = '*';
            this.password.Size = new System.Drawing.Size(132, 22);
            this.password.TabIndex = 1;
            this.password.UseSystemPasswordChar = true;
            this.password.TextChanged += new System.EventHandler(this.password_TextChanged);
            // 
            // email
            // 
            this.email.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.email.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.email.Location = new System.Drawing.Point(323, 256);
            this.email.Margin = new System.Windows.Forms.Padding(4);
            this.email.Name = "email";
            this.email.Size = new System.Drawing.Size(132, 22);
            this.email.TabIndex = 2;
            this.email.TextChanged += new System.EventHandler(this.email_TextChanged);
            // 
            // firstName
            // 
            this.firstName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.firstName.Location = new System.Drawing.Point(323, 122);
            this.firstName.Margin = new System.Windows.Forms.Padding(4);
            this.firstName.Name = "firstName";
            this.firstName.Size = new System.Drawing.Size(132, 22);
            this.firstName.TabIndex = 3;
            this.firstName.TextChanged += new System.EventHandler(this.firstName_TextChanged);
            // 
            // lastName
            // 
            this.lastName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastName.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lastName.Location = new System.Drawing.Point(323, 188);
            this.lastName.Margin = new System.Windows.Forms.Padding(4);
            this.lastName.Name = "lastName";
            this.lastName.Size = new System.Drawing.Size(132, 22);
            this.lastName.TabIndex = 4;
            this.lastName.TextChanged += new System.EventHandler(this.lastName_TextChanged);
            // 
            // confirm
            // 
            this.confirm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.confirm.Location = new System.Drawing.Point(133, 256);
            this.confirm.Margin = new System.Windows.Forms.Padding(4);
            this.confirm.Name = "confirm";
            this.confirm.PasswordChar = '*';
            this.confirm.Size = new System.Drawing.Size(132, 22);
            this.confirm.TabIndex = 6;
            this.confirm.UseSystemPasswordChar = true;
            this.confirm.TextChanged += new System.EventHandler(this.confirm_TextChanged);
            // 
            // UsernameLabel
            // 
            this.UsernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.UsernameLabel.AutoSize = true;
            this.UsernameLabel.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UsernameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.UsernameLabel.Location = new System.Drawing.Point(134, 101);
            this.UsernameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UsernameLabel.Name = "UsernameLabel";
            this.UsernameLabel.Size = new System.Drawing.Size(83, 19);
            this.UsernameLabel.TabIndex = 7;
            this.UsernameLabel.Text = "Username";
            this.UsernameLabel.Click += new System.EventHandler(this.UsernameLabel_Click);
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.passwordLabel.Location = new System.Drawing.Point(134, 167);
            this.passwordLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(80, 19);
            this.passwordLabel.TabIndex = 8;
            this.passwordLabel.Text = "Password";
            // 
            // confirmLabel
            // 
            this.confirmLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmLabel.AutoSize = true;
            this.confirmLabel.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.confirmLabel.Location = new System.Drawing.Point(134, 233);
            this.confirmLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(145, 19);
            this.confirmLabel.TabIndex = 9;
            this.confirmLabel.Text = "Confirm Password";
            this.confirmLabel.Click += new System.EventHandler(this.confirmLabel_Click);
            // 
            // emailLabel
            // 
            this.emailLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.emailLabel.AutoSize = true;
            this.emailLabel.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.emailLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.emailLabel.Location = new System.Drawing.Point(326, 235);
            this.emailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(51, 19);
            this.emailLabel.TabIndex = 10;
            this.emailLabel.Text = "Email";
            // 
            // firstnameLabel
            // 
            this.firstnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.firstnameLabel.AutoSize = true;
            this.firstnameLabel.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.firstnameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.firstnameLabel.Location = new System.Drawing.Point(326, 101);
            this.firstnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.firstnameLabel.Name = "firstnameLabel";
            this.firstnameLabel.Size = new System.Drawing.Size(88, 19);
            this.firstnameLabel.TabIndex = 11;
            this.firstnameLabel.Text = "First Name";
            // 
            // lastnameLabel
            // 
            this.lastnameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lastnameLabel.AutoSize = true;
            this.lastnameLabel.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.lastnameLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lastnameLabel.Location = new System.Drawing.Point(326, 167);
            this.lastnameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lastnameLabel.Name = "lastnameLabel";
            this.lastnameLabel.Size = new System.Drawing.Size(86, 19);
            this.lastnameLabel.TabIndex = 12;
            this.lastnameLabel.Text = "Last Name";
            this.lastnameLabel.Click += new System.EventHandler(this.lastnameLabel_Click);
            // 
            // levelAccessLabel
            // 
            this.levelAccessLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.levelAccessLabel.AutoSize = true;
            this.levelAccessLabel.Font = new System.Drawing.Font("Britannic Bold", 10.2F);
            this.levelAccessLabel.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.levelAccessLabel.Location = new System.Drawing.Point(522, 167);
            this.levelAccessLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.levelAccessLabel.Name = "levelAccessLabel";
            this.levelAccessLabel.Size = new System.Drawing.Size(100, 19);
            this.levelAccessLabel.TabIndex = 13;
            this.levelAccessLabel.Text = "Level Access";
            // 
            // submit
            // 
            this.submit.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.submit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.submit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.submit.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.submit.Location = new System.Drawing.Point(329, 313);
            this.submit.Margin = new System.Windows.Forms.Padding(4);
            this.submit.Name = "submit";
            this.submit.Size = new System.Drawing.Size(100, 28);
            this.submit.TabIndex = 14;
            this.submit.Text = "Register";
            this.submit.UseVisualStyleBackColor = true;
            this.submit.Click += new System.EventHandler(this.submit_Click);
            // 
            // error
            // 
            this.error.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.error.AutoSize = true;
            this.error.ForeColor = System.Drawing.Color.Red;
            this.error.Location = new System.Drawing.Point(431, 81);
            this.error.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.error.Name = "error";
            this.error.Size = new System.Drawing.Size(0, 17);
            this.error.TabIndex = 15;
            // 
            // back
            // 
            this.back.AutoSize = true;
            this.back.BackColor = System.Drawing.Color.Transparent;
            this.back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.back.FlatAppearance.BorderSize = 0;
            this.back.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.back.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.ImageIndex = 1;
            this.back.ImageList = this.backButtonList;
            this.back.Location = new System.Drawing.Point(13, 13);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(86, 86);
            this.back.TabIndex = 17;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // backButtonList
            // 
            this.backButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("backButtonList.ImageStream")));
            this.backButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.backButtonList.Images.SetKeyName(0, "icons8-rewind-button-round-80.png");
            this.backButtonList.Images.SetKeyName(1, "backbutton.png");
            // 
            // ast1
            // 
            this.ast1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.ast1.AutoSize = true;
            this.ast1.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ast1.ForeColor = System.Drawing.Color.Red;
            this.ast1.Location = new System.Drawing.Point(216, 101);
            this.ast1.Name = "ast1";
            this.ast1.Size = new System.Drawing.Size(16, 19);
            this.ast1.TabIndex = 18;
            this.ast1.Text = "*";
            this.ast1.Visible = false;
            // 
            // passAst
            // 
            this.passAst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passAst.AutoSize = true;
            this.passAst.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passAst.ForeColor = System.Drawing.Color.Red;
            this.passAst.Location = new System.Drawing.Point(216, 167);
            this.passAst.Name = "passAst";
            this.passAst.Size = new System.Drawing.Size(16, 19);
            this.passAst.TabIndex = 19;
            this.passAst.Text = "*";
            this.passAst.Visible = false;
            this.passAst.Click += new System.EventHandler(this.label1_Click);
            // 
            // conPassAst
            // 
            this.conPassAst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.conPassAst.AutoSize = true;
            this.conPassAst.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conPassAst.ForeColor = System.Drawing.Color.Red;
            this.conPassAst.Location = new System.Drawing.Point(276, 233);
            this.conPassAst.Name = "conPassAst";
            this.conPassAst.Size = new System.Drawing.Size(16, 19);
            this.conPassAst.TabIndex = 20;
            this.conPassAst.Text = "*";
            this.conPassAst.Visible = false;
            // 
            // fNameAst
            // 
            this.fNameAst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.fNameAst.AutoSize = true;
            this.fNameAst.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fNameAst.ForeColor = System.Drawing.Color.Red;
            this.fNameAst.Location = new System.Drawing.Point(413, 101);
            this.fNameAst.Name = "fNameAst";
            this.fNameAst.Size = new System.Drawing.Size(16, 19);
            this.fNameAst.TabIndex = 21;
            this.fNameAst.Text = "*";
            this.fNameAst.Visible = false;
            // 
            // lNameAst
            // 
            this.lNameAst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lNameAst.AutoSize = true;
            this.lNameAst.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNameAst.ForeColor = System.Drawing.Color.Red;
            this.lNameAst.Location = new System.Drawing.Point(413, 167);
            this.lNameAst.Name = "lNameAst";
            this.lNameAst.Size = new System.Drawing.Size(16, 19);
            this.lNameAst.TabIndex = 22;
            this.lNameAst.Text = "*";
            this.lNameAst.Visible = false;
            // 
            // eAst
            // 
            this.eAst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.eAst.AutoSize = true;
            this.eAst.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.eAst.ForeColor = System.Drawing.Color.Red;
            this.eAst.Location = new System.Drawing.Point(375, 233);
            this.eAst.Name = "eAst";
            this.eAst.Size = new System.Drawing.Size(16, 19);
            this.eAst.TabIndex = 23;
            this.eAst.Text = "*";
            this.eAst.Visible = false;
            // 
            // accessAst
            // 
            this.accessAst.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.accessAst.AutoSize = true;
            this.accessAst.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accessAst.ForeColor = System.Drawing.Color.Red;
            this.accessAst.Location = new System.Drawing.Point(619, 167);
            this.accessAst.Name = "accessAst";
            this.accessAst.Size = new System.Drawing.Size(16, 19);
            this.accessAst.TabIndex = 24;
            this.accessAst.Text = "*";
            // 
            // roleCombo
            // 
            this.roleCombo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.roleCombo.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.roleCombo.FormattingEnabled = true;
            this.roleCombo.Items.AddRange(new object[] {
            "Admin",
            "IT Support Member",
            "Project Member",
            "Report Manager"});
            this.roleCombo.Location = new System.Drawing.Point(526, 189);
            this.roleCombo.Name = "roleCombo";
            this.roleCombo.Size = new System.Drawing.Size(160, 24);
            this.roleCombo.TabIndex = 25;
            // 
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("ROG Fonts", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimizeBtn.Location = new System.Drawing.Point(688, 9);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 32);
            this.minimizeBtn.TabIndex = 28;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // fullBtn
            // 
            this.fullBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullBtn.FlatAppearance.BorderSize = 2;
            this.fullBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.fullBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.fullBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fullBtn.Location = new System.Drawing.Point(718, 20);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(20, 12);
            this.fullBtn.TabIndex = 27;
            this.fullBtn.UseVisualStyleBackColor = true;
            this.fullBtn.Click += new System.EventHandler(this.fullBtn_Click);
            // 
            // exitBtn
            // 
            this.exitBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exitBtn.FlatAppearance.BorderSize = 0;
            this.exitBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.exitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.exitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitBtn.Font = new System.Drawing.Font("ROG Fonts", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Location = new System.Drawing.Point(741, 9);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(43, 32);
            this.exitBtn.TabIndex = 26;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(793, 429);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.fullBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.roleCombo);
            this.Controls.Add(this.accessAst);
            this.Controls.Add(this.eAst);
            this.Controls.Add(this.lNameAst);
            this.Controls.Add(this.fNameAst);
            this.Controls.Add(this.conPassAst);
            this.Controls.Add(this.passAst);
            this.Controls.Add(this.ast1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.error);
            this.Controls.Add(this.submit);
            this.Controls.Add(this.levelAccessLabel);
            this.Controls.Add(this.lastnameLabel);
            this.Controls.Add(this.firstnameLabel);
            this.Controls.Add(this.emailLabel);
            this.Controls.Add(this.confirmLabel);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.UsernameLabel);
            this.Controls.Add(this.confirm);
            this.Controls.Add(this.lastName);
            this.Controls.Add(this.firstName);
            this.Controls.Add(this.email);
            this.Controls.Add(this.password);
            this.Controls.Add(this.username);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register New User";
            this.Load += new System.EventHandler(this.register_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.TextBox password;
        private System.Windows.Forms.TextBox email;
        private System.Windows.Forms.TextBox firstName;
        private System.Windows.Forms.TextBox lastName;
        private System.Windows.Forms.TextBox confirm;
        private System.Windows.Forms.Label UsernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.Label firstnameLabel;
        private System.Windows.Forms.Label lastnameLabel;
        private System.Windows.Forms.Label levelAccessLabel;
        private System.Windows.Forms.Button submit;
        private System.Windows.Forms.Label error;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ImageList backButtonList;
        private System.Windows.Forms.Label ast1;
        private System.Windows.Forms.Label passAst;
        private System.Windows.Forms.Label conPassAst;
        private System.Windows.Forms.Label fNameAst;
        private System.Windows.Forms.Label lNameAst;
        private System.Windows.Forms.Label eAst;
        private System.Windows.Forms.Label accessAst;
        private System.Windows.Forms.ComboBox roleCombo;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}