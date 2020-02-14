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
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // logOut
            // 
            this.logOut.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.logOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logOut.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.logOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.logOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.logOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logOut.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.logOut.Location = new System.Drawing.Point(0, 47);
            this.logOut.Margin = new System.Windows.Forms.Padding(0);
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
            this.register.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.register.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.register.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.register.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.register.Location = new System.Drawing.Point(0, 0);
            this.register.Margin = new System.Windows.Forms.Padding(0);
            this.register.Name = "register";
            this.register.Size = new System.Drawing.Size(214, 47);
            this.register.TabIndex = 1;
            this.register.Text = "Register New User";
            this.register.UseVisualStyleBackColor = false;
            this.register.Click += new System.EventHandler(this.register_Click);
            // 
            // optionPanel
            // 
            this.optionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.optionPanel.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.optionPanel.Controls.Add(this.register);
            this.optionPanel.Controls.Add(this.logOut);
            this.optionPanel.Location = new System.Drawing.Point(-2, 59);
            this.optionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(214, 501);
            this.optionPanel.TabIndex = 2;
            this.optionPanel.Visible = false;
            this.optionPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
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
            this.fullBtn.Location = new System.Drawing.Point(992, 18);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(20, 12);
            this.fullBtn.TabIndex = 17;
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
            this.exitBtn.Location = new System.Drawing.Point(1015, 7);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(43, 32);
            this.exitBtn.TabIndex = 16;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.fullBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.buttonCollapse);
            this.Controls.Add(this.optionPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            this.optionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button logOut;
        private System.Windows.Forms.Button register;
        private System.Windows.Forms.FlowLayoutPanel optionPanel;
        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button exitBtn;
    }
}