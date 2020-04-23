namespace unnamedProject.Forms
{
    partial class SupportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SupportForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.openTab = new System.Windows.Forms.Button();
            this.closedTab = new System.Windows.Forms.Button();
            this.FAPTab = new System.Windows.Forms.Button();
            this.newTab = new System.Windows.Forms.Button();
            this.onlineHelpBtn = new System.Windows.Forms.Button();
            this.OpenList = new System.Windows.Forms.ListBox();
            this.optionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.LblHello = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.SystemColors.WindowFrame;
            this.imageList1.Images.SetKeyName(0, "588a6507d06f6719692a2d15.png");
            this.imageList1.Images.SetKeyName(1, "icons8-restore-down-52.png");
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "icons8-restore-down-52.png");
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
            this.buttonCollapse.Size = new System.Drawing.Size(63, 46);
            this.buttonCollapse.TabIndex = 4;
            this.buttonCollapse.UseVisualStyleBackColor = false;
            this.buttonCollapse.Click += new System.EventHandler(this.buttonCollapse_Click);
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
            this.minimizeBtn.Location = new System.Drawing.Point(962, 7);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 32);
            this.minimizeBtn.TabIndex = 21;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click_1);
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
            this.fullBtn.TabIndex = 20;
            this.fullBtn.UseVisualStyleBackColor = true;
            this.fullBtn.Click += new System.EventHandler(this.fullBtn_Click_1);
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
            this.exitBtn.Location = new System.Drawing.Point(1015, 9);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(43, 32);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.mainPanel.Controls.Add(this.openTab);
            this.mainPanel.Controls.Add(this.closedTab);
            this.mainPanel.Controls.Add(this.FAPTab);
            this.mainPanel.Controls.Add(this.newTab);
            this.mainPanel.Controls.Add(this.onlineHelpBtn);
            this.mainPanel.Controls.Add(this.OpenList);
            this.mainPanel.Location = new System.Drawing.Point(5, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1063, 498);
            this.mainPanel.TabIndex = 22;
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
            this.openTab.TabIndex = 6;
            this.openTab.Text = "Open";
            this.openTab.UseVisualStyleBackColor = true;
            this.openTab.Click += new System.EventHandler(this.openTab_Click);
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
            this.closedTab.TabIndex = 7;
            this.closedTab.Text = "Closed";
            this.closedTab.UseVisualStyleBackColor = true;
            this.closedTab.Click += new System.EventHandler(this.closedTab_Click);
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
            this.FAPTab.TabIndex = 8;
            this.FAPTab.Text = "FAP";
            this.FAPTab.UseVisualStyleBackColor = true;
            this.FAPTab.Click += new System.EventHandler(this.FAPTab_Click);
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
            this.newTab.TabIndex = 9;
            this.newTab.Text = "New";
            this.newTab.UseVisualStyleBackColor = true;
            this.newTab.Click += new System.EventHandler(this.newTab_Click);
            // 
            // onlineHelpBtn
            // 
            this.onlineHelpBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.onlineHelpBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.onlineHelpBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.onlineHelpBtn.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.onlineHelpBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.onlineHelpBtn.Location = new System.Drawing.Point(302, 0);
            this.onlineHelpBtn.Margin = new System.Windows.Forms.Padding(0, 0, 600, 0);
            this.onlineHelpBtn.Name = "onlineHelpBtn";
            this.onlineHelpBtn.Size = new System.Drawing.Size(116, 29);
            this.onlineHelpBtn.TabIndex = 10;
            this.onlineHelpBtn.Text = "Online Help";
            this.onlineHelpBtn.UseVisualStyleBackColor = true;
            this.onlineHelpBtn.Click += new System.EventHandler(this.onlineHelpBtn_Click);
            // 
            // OpenList
            // 
            this.OpenList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OpenList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.OpenList.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.OpenList.FormattingEnabled = true;
            this.OpenList.HorizontalScrollbar = true;
            this.OpenList.ItemHeight = 16;
            this.OpenList.Location = new System.Drawing.Point(4, 33);
            this.OpenList.Margin = new System.Windows.Forms.Padding(4);
            this.OpenList.Name = "OpenList";
            this.OpenList.Size = new System.Drawing.Size(1043, 436);
            this.OpenList.TabIndex = 11;
            this.OpenList.SelectedIndexChanged += new System.EventHandler(this.OpenList_SelectedIndexChanged);
            // 
            // optionPanel
            // 
            this.optionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(94)))));
            this.optionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionPanel.Controls.Add(this.settingsBtn);
            this.optionPanel.Controls.Add(this.logOut);
            this.optionPanel.Location = new System.Drawing.Point(-5, 64);
            this.optionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(212, 498);
            this.optionPanel.TabIndex = 23;
            this.optionPanel.Visible = false;
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
            this.settingsBtn.Location = new System.Drawing.Point(0, 1);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(214, 28);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.Text = "Account Preferences";
            this.settingsBtn.UseVisualStyleBackColor = false;
            this.settingsBtn.Click += new System.EventHandler(this.settingsBtn_Click);
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
            this.logOut.Location = new System.Drawing.Point(0, 31);
            this.logOut.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(214, 28);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Sign Out";
            this.logOut.UseVisualStyleBackColor = false;
            this.logOut.Click += new System.EventHandler(this.logOut_Click_1);
            // 
            // LblHello
            // 
            this.LblHello.AutoSize = true;
            this.LblHello.Font = new System.Drawing.Font("Britannic Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblHello.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblHello.Location = new System.Drawing.Point(413, 17);
            this.LblHello.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblHello.Name = "LblHello";
            this.LblHello.Size = new System.Drawing.Size(60, 22);
            this.LblHello.TabIndex = 24;
            this.LblHello.Text = "Hello ";
            // 
            // SupportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.LblHello);
            this.Controls.Add(this.optionPanel);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.fullBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.buttonCollapse);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SupportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SupportForm";
            this.Load += new System.EventHandler(this.SupportForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.optionPanel.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Button openTab;
        private System.Windows.Forms.Button closedTab;
        private System.Windows.Forms.Button FAPTab;
        private System.Windows.Forms.Button newTab;
        private System.Windows.Forms.Button onlineHelpBtn;
        private System.Windows.Forms.FlowLayoutPanel optionPanel;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.ListBox OpenList;
        private System.Windows.Forms.Label LblHello;
    }
}