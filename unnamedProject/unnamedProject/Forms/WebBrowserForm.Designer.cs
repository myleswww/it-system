namespace unnamedProject
{
    partial class WebBrowserForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WebBrowserForm));
            this.backButtonList = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.back = new System.Windows.Forms.Button();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.wbrDisplay = new System.Windows.Forms.WebBrowser();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.btnGo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backButtonList
            // 
            this.backButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("backButtonList.ImageStream")));
            this.backButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.backButtonList.Images.SetKeyName(0, "icons8-rewind-button-round-80.png");
            this.backButtonList.Images.SetKeyName(1, "backbutton.png");
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
            this.back.Size = new System.Drawing.Size(48, 48);
            this.back.TabIndex = 23;
            this.back.UseVisualStyleBackColor = false;
            this.back.Click += new System.EventHandler(this.back_Click);
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
            this.minimizeBtn.Location = new System.Drawing.Point(864, 8);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(21, 30);
            this.minimizeBtn.TabIndex = 26;
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
            this.fullBtn.Location = new System.Drawing.Point(890, 18);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(18, 11);
            this.fullBtn.TabIndex = 25;
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
            this.exitBtn.Location = new System.Drawing.Point(910, 9);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 30);
            this.exitBtn.TabIndex = 24;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Britannic Bold", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblTitle.Location = new System.Drawing.Point(393, 21);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(137, 27);
            this.lblTitle.TabIndex = 27;
            this.lblTitle.Text = "Online Help";
            // 
            // wbrDisplay
            // 
            this.wbrDisplay.Location = new System.Drawing.Point(12, 113);
            this.wbrDisplay.MinimumSize = new System.Drawing.Size(20, 20);
            this.wbrDisplay.Name = "wbrDisplay";
            this.wbrDisplay.Size = new System.Drawing.Size(936, 428);
            this.wbrDisplay.TabIndex = 28;
            // 
            // txtURL
            // 
            this.txtURL.ForeColor = System.Drawing.Color.Fuchsia;
            this.txtURL.Location = new System.Drawing.Point(211, 76);
            this.txtURL.Name = "txtURL";
            this.txtURL.Size = new System.Drawing.Size(359, 22);
            this.txtURL.TabIndex = 29;
            // 
            // btnGo
            // 
            this.btnGo.ForeColor = System.Drawing.Color.Fuchsia;
            this.btnGo.Location = new System.Drawing.Point(625, 71);
            this.btnGo.Name = "btnGo";
            this.btnGo.Size = new System.Drawing.Size(75, 32);
            this.btnGo.TabIndex = 30;
            this.btnGo.Text = "Go";
            this.btnGo.UseVisualStyleBackColor = true;
            this.btnGo.Click += new System.EventHandler(this.btnGo_Click);
            // 
            // WebBrowserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(957, 553);
            this.Controls.Add(this.btnGo);
            this.Controls.Add(this.txtURL);
            this.Controls.Add(this.wbrDisplay);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.fullBtn);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.back);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "WebBrowserForm";
            this.Text = "WebBrowserForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList backButtonList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.WebBrowser wbrDisplay;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.Button btnGo;
    }
}