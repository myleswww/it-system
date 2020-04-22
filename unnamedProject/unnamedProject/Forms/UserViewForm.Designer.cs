namespace unnamedProject.Forms
{
    partial class UserViewForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserViewForm));
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.backButtonList = new System.Windows.Forms.ImageList(this.components);
            this.back = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.ComboBoxSort = new System.Windows.Forms.ComboBox();
            this.LblName = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblLvlAccess = new System.Windows.Forms.Label();
            this.LstBxUser = new System.Windows.Forms.ListBox();
            this.LblAllUsers = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
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
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimizeBtn.Location = new System.Drawing.Point(608, 7);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(21, 30);
            this.minimizeBtn.TabIndex = 21;
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
            this.fullBtn.Location = new System.Drawing.Point(634, 17);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(18, 11);
            this.fullBtn.TabIndex = 20;
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
            this.exitBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.exitBtn.Location = new System.Drawing.Point(654, 8);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 30);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // backButtonList
            // 
            this.backButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("backButtonList.ImageStream")));
            this.backButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.backButtonList.Images.SetKeyName(0, "icons8-rewind-button-round-80.png");
            this.backButtonList.Images.SetKeyName(1, "backbutton.png");
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
            this.back.Location = new System.Drawing.Point(2, 0);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(48, 48);
            this.back.TabIndex = 22;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.ComboBoxSort);
            this.flowLayoutPanel1.Controls.Add(this.LblName);
            this.flowLayoutPanel1.Controls.Add(this.LblID);
            this.flowLayoutPanel1.Controls.Add(this.LblLvlAccess);
            this.flowLayoutPanel1.Controls.Add(this.LstBxUser);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(2, 64);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(697, 357);
            this.flowLayoutPanel1.TabIndex = 23;
            // 
            // ComboBoxSort
            // 
            this.ComboBoxSort.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.ComboBoxSort.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ComboBoxSort.Font = new System.Drawing.Font("Britannic Bold", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBoxSort.ForeColor = System.Drawing.Color.Black;
            this.ComboBoxSort.FormattingEnabled = true;
            this.ComboBoxSort.Items.AddRange(new object[] {
            "User Id",
            "A-Z",
            "Z-A"});
            this.ComboBoxSort.Location = new System.Drawing.Point(3, 3);
            this.ComboBoxSort.Name = "ComboBoxSort";
            this.ComboBoxSort.Size = new System.Drawing.Size(70, 23);
            this.ComboBoxSort.TabIndex = 0;
            this.ComboBoxSort.Text = "Sort By";
            this.ComboBoxSort.SelectedIndexChanged += new System.EventHandler(this.ComboBoxSort_SelectedIndexChanged);
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblName.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblName.Location = new System.Drawing.Point(79, 0);
            this.LblName.Margin = new System.Windows.Forms.Padding(3, 0, 118, 0);
            this.LblName.Name = "LblName";
            this.LblName.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LblName.Size = new System.Drawing.Size(46, 28);
            this.LblName.TabIndex = 4;
            this.LblName.Text = "Name";
            this.LblName.Click += new System.EventHandler(this.LblName_Click);
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblID.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblID.Location = new System.Drawing.Point(246, 0);
            this.LblID.Margin = new System.Windows.Forms.Padding(3, 0, 214, 0);
            this.LblID.Name = "LblID";
            this.LblID.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LblID.Size = new System.Drawing.Size(25, 28);
            this.LblID.TabIndex = 5;
            this.LblID.Text = "ID";
            // 
            // LblLvlAccess
            // 
            this.LblLvlAccess.AutoSize = true;
            this.LblLvlAccess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.SetFlowBreak(this.LblLvlAccess, true);
            this.LblLvlAccess.Font = new System.Drawing.Font("Britannic Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLvlAccess.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblLvlAccess.Location = new System.Drawing.Point(488, 0);
            this.LblLvlAccess.Name = "LblLvlAccess";
            this.LblLvlAccess.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            this.LblLvlAccess.Size = new System.Drawing.Size(38, 28);
            this.LblLvlAccess.TabIndex = 6;
            this.LblLvlAccess.Text = "Role";
            // 
            // LstBxUser
            // 
            this.LstBxUser.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstBxUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstBxUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LstBxUser.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LstBxUser.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LstBxUser.FormattingEnabled = true;
            this.LstBxUser.ItemHeight = 19;
            this.LstBxUser.Location = new System.Drawing.Point(0, 29);
            this.LstBxUser.Margin = new System.Windows.Forms.Padding(0);
            this.LstBxUser.Name = "LstBxUser";
            this.LstBxUser.Size = new System.Drawing.Size(693, 325);
            this.LstBxUser.TabIndex = 7;
            // 
            // LblAllUsers
            // 
            this.LblAllUsers.AutoSize = true;
            this.LblAllUsers.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblAllUsers.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblAllUsers.Location = new System.Drawing.Point(265, 17);
            this.LblAllUsers.Name = "LblAllUsers";
            this.LblAllUsers.Size = new System.Drawing.Size(160, 27);
            this.LblAllUsers.TabIndex = 24;
            this.LblAllUsers.Text = "View All Users";
            // 
            // UserViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(700, 422);
            this.Controls.Add(this.LblAllUsers);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.fullBtn);
            this.Controls.Add(this.exitBtn);
            this.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserViewForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserViewForm";
            this.Load += new System.EventHandler(this.UserViewForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ImageList backButtonList;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.ComboBox ComboBoxSort;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblLvlAccess;
        private System.Windows.Forms.Label LblAllUsers;
        private System.Windows.Forms.ListBox LstBxUser;
    }
}