namespace unnamedProject
{
    partial class AdminForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminForm));
            this.logOut = new System.Windows.Forms.Button();
            this.register = new System.Windows.Forms.Button();
            this.optionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.usersBtn = new System.Windows.Forms.Button();
            this.problemBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.exitBtn = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.newTab = new System.Windows.Forms.Button();
            this.FAPTab = new System.Windows.Forms.Button();
            this.closedTab = new System.Windows.Forms.Button();
            this.openTab = new System.Windows.Forms.Button();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel4 = new System.Windows.Forms.FlowLayoutPanel();
            this.onlineHelpBtn = new System.Windows.Forms.Button();
            this.optionPanel.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOut.FlatAppearance.BorderSize = 0;
            this.logOut.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.logOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.logOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOut.Location = new System.Drawing.Point(0, 151);
            this.logOut.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(214, 28);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click);
            // 
            // register
            // 
            this.register.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.register.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.register.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.register.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.register.FlatAppearance.BorderSize = 0;
            this.register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register.Location = new System.Drawing.Point(0, 1);
            this.register.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(214, 28);
            this.register.TabIndex = 1;
            this.register.Text = "Register New User";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // optionPanel
            // 
            this.optionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(94)))));
            this.optionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionPanel.Controls.Add(this.register);
            this.optionPanel.Controls.Add(this.usersBtn);
            this.optionPanel.Controls.Add(this.problemBtn);
            this.optionPanel.Controls.Add(this.reportBtn);
            this.optionPanel.Controls.Add(this.settingsBtn);
            this.optionPanel.Controls.Add(this.logOut);
            this.optionPanel.Location = new System.Drawing.Point(1, 59);
            this.optionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(214, 501);
            this.optionPanel.TabIndex = 2;
            this.optionPanel.Visible = false;
            // 
            // usersBtn
            // 
            this.usersBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.usersBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.usersBtn.FlatAppearance.BorderSize = 0;
            this.usersBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.usersBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.usersBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.usersBtn.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.usersBtn.Location = new System.Drawing.Point(0, 31);
            this.usersBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.usersBtn.Name = "usersBtn";
            this.usersBtn.Size = new System.Drawing.Size(214, 28);
            this.usersBtn.TabIndex = 2;
            this.usersBtn.Text = "All Users";
            this.usersBtn.UseVisualStyleBackColor = false;
            // 
            // problemBtn
            // 
            this.problemBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.problemBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.problemBtn.FlatAppearance.BorderSize = 0;
            this.problemBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.problemBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.problemBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.problemBtn.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.problemBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.problemBtn.Location = new System.Drawing.Point(0, 61);
            this.problemBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.problemBtn.Name = "problemBtn";
            this.problemBtn.Size = new System.Drawing.Size(214, 28);
            this.problemBtn.TabIndex = 3;
            this.problemBtn.Text = "View Existing Problems";
            this.problemBtn.UseVisualStyleBackColor = false;
            // 
            // reportBtn
            // 
            this.reportBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.reportBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportBtn.FlatAppearance.BorderSize = 0;
            this.reportBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.reportBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.reportBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.reportBtn.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.reportBtn.Location = new System.Drawing.Point(0, 91);
            this.reportBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.reportBtn.Name = "reportBtn";
            this.reportBtn.Size = new System.Drawing.Size(214, 28);
            this.reportBtn.TabIndex = 4;
            this.reportBtn.Text = "Generate Report";
            this.reportBtn.UseVisualStyleBackColor = false;
            // 
            // settingsBtn
            // 
            this.settingsBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.settingsBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.settingsBtn.FlatAppearance.BorderSize = 0;
            this.settingsBtn.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.settingsBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.settingsBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingsBtn.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.settingsBtn.Location = new System.Drawing.Point(0, 121);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(214, 28);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
            // 
            // buttonCollapse
            // 
            this.buttonCollapse.BackColor = System.Drawing.Color.Transparent;
            this.buttonCollapse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonCollapse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonCollapse.FlatAppearance.BorderSize = 0;
            this.buttonCollapse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonCollapse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonCollapse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCollapse.ForeColor = System.Drawing.Color.Transparent;
            this.buttonCollapse.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonCollapse.ImageIndex = 0;
            this.buttonCollapse.ImageList = this.imageList1;
            this.buttonCollapse.Location = new System.Drawing.Point(16, 7);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(70, 46);
            this.buttonCollapse.TabIndex = 3;
            this.buttonCollapse.UseVisualStyleBackColor = false;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.SystemColors.WindowFrame;
            this.imageList1.Images.SetKeyName(0, "588a6507d06f6719692a2d15.png");
            this.imageList1.Images.SetKeyName(1, "icons8-restore-down-52.png");
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
            this.minimizeBtn.Location = new System.Drawing.Point(962, 7);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 32);
            this.minimizeBtn.TabIndex = 18;
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
            this.fullBtn.ImageList = this.imageList2;
            this.fullBtn.Location = new System.Drawing.Point(992, 18);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(20, 12);
            this.fullBtn.TabIndex = 17;
            this.fullBtn.UseVisualStyleBackColor = true;
            this.fullBtn.Click += new System.EventHandler(this.fullBtn_Click);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icons8-restore-down-52.png");
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
            this.exitBtn.Location = new System.Drawing.Point(1015, 9);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(43, 32);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.Controls.Add(this.flowLayoutPanel2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(1, 59);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1067, 490);
            this.flowLayoutPanel1.TabIndex = 19;
            // 
            // newTab
            // 
            this.newTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.newTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.newTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.newTab.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.newTab.Location = new System.Drawing.Point(227, 0);
            this.newTab.Margin = new System.Windows.Forms.Padding(0);
            this.newTab.Name = "newTab";
            this.newTab.Size = new System.Drawing.Size(75, 29);
            this.newTab.TabIndex = 3;
            this.newTab.Text = "New";
            this.newTab.UseVisualStyleBackColor = true;
            // 
            // FAPTab
            // 
            this.FAPTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.FAPTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.FAPTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.FAPTab.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FAPTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.FAPTab.Location = new System.Drawing.Point(152, 0);
            this.FAPTab.Margin = new System.Windows.Forms.Padding(0);
            this.FAPTab.Name = "FAPTab";
            this.FAPTab.Size = new System.Drawing.Size(75, 29);
            this.FAPTab.TabIndex = 2;
            this.FAPTab.Text = "FAP";
            this.FAPTab.UseVisualStyleBackColor = true;
            // 
            // closedTab
            // 
            this.closedTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.closedTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.closedTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closedTab.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.closedTab.Location = new System.Drawing.Point(77, 0);
            this.closedTab.Margin = new System.Windows.Forms.Padding(0);
            this.closedTab.Name = "closedTab";
            this.closedTab.Size = new System.Drawing.Size(75, 29);
            this.closedTab.TabIndex = 1;
            this.closedTab.Text = "Closed";
            this.closedTab.UseVisualStyleBackColor = true;
            // 
            // openTab
            // 
            this.openTab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.openTab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.openTab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.openTab.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openTab.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.openTab.Location = new System.Drawing.Point(2, 0);
            this.openTab.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.openTab.Name = "openTab";
            this.openTab.Size = new System.Drawing.Size(75, 29);
            this.openTab.TabIndex = 0;
            this.openTab.Text = "Open";
            this.openTab.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.openTab);
            this.flowLayoutPanel2.Controls.Add(this.closedTab);
            this.flowLayoutPanel2.Controls.Add(this.FAPTab);
            this.flowLayoutPanel2.Controls.Add(this.newTab);
            this.flowLayoutPanel2.Controls.Add(this.onlineHelpBtn);
            this.flowLayoutPanel2.Controls.Add(this.flowLayoutPanel3);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(1057, 483);
            this.flowLayoutPanel2.TabIndex = 22;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.flowLayoutPanel4);
            this.flowLayoutPanel3.Location = new System.Drawing.Point(3, 32);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(1054, 451);
            this.flowLayoutPanel3.TabIndex = 4;
            // 
            // flowLayoutPanel4
            // 
            this.flowLayoutPanel4.Location = new System.Drawing.Point(3, 3);
            this.flowLayoutPanel4.Name = "flowLayoutPanel4";
            this.flowLayoutPanel4.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel4.TabIndex = 0;
            // 
            // onlineHelpBtn
            // 
            this.onlineHelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.onlineHelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.onlineHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlineHelpBtn.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineHelpBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.onlineHelpBtn.Location = new System.Drawing.Point(302, 0);
            this.onlineHelpBtn.Margin = new System.Windows.Forms.Padding(0);
            this.onlineHelpBtn.Name = "onlineHelpBtn";
            this.onlineHelpBtn.Size = new System.Drawing.Size(116, 29);
            this.onlineHelpBtn.TabIndex = 5;
            this.onlineHelpBtn.Text = "Online Help";
            this.onlineHelpBtn.UseVisualStyleBackColor = true;
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.optionPanel);
            this.Controls.Add(this.buttonCollapse);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.fullBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.optionPanel.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.FlowLayoutPanel optionPanel;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button usersBtn;
        private System.Windows.Forms.Button problemBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Button openTab;
        private System.Windows.Forms.Button closedTab;
        private System.Windows.Forms.Button FAPTab;
        private System.Windows.Forms.Button newTab;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel4;
        private System.Windows.Forms.Button onlineHelpBtn;
    }
}