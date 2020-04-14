namespace unnamedProject.Forms
{
    partial class GenerateReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GenerateReportForm));
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.back = new System.Windows.Forms.Button();
            this.backButtonList = new System.Windows.Forms.ImageList(this.components);
            this.lblReportText = new System.Windows.Forms.Label();
            this.btnUnsolvedTicket = new System.Windows.Forms.Button();
            this.btnSolvedTickets = new System.Windows.Forms.Button();
            this.btnExistingTickets = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.BtnViewReports = new System.Windows.Forms.Button();
            this.SuspendLayout();
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
            this.minimizeBtn.Location = new System.Drawing.Point(707, 8);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(21, 30);
            this.minimizeBtn.TabIndex = 29;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
            // 
            // fullBtn
            // 
            this.fullBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullBtn.FlatAppearance.BorderColor = System.Drawing.SystemColors.ControlLightLight;
            this.fullBtn.FlatAppearance.BorderSize = 2;
            this.fullBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.fullBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.fullBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fullBtn.Location = new System.Drawing.Point(733, 18);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(18, 11);
            this.fullBtn.TabIndex = 28;
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
            this.exitBtn.Location = new System.Drawing.Point(753, 9);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 30);
            this.exitBtn.TabIndex = 27;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
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
            this.back.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.ImageKey = "backbutton.png";
            this.back.ImageList = this.backButtonList;
            this.back.Location = new System.Drawing.Point(13, 13);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(48, 48);
            this.back.TabIndex = 30;
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
            // lblReportText
            // 
            this.lblReportText.AutoSize = true;
            this.lblReportText.Font = new System.Drawing.Font("Britannic Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReportText.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblReportText.Location = new System.Drawing.Point(269, 130);
            this.lblReportText.Name = "lblReportText";
            this.lblReportText.Size = new System.Drawing.Size(102, 19);
            this.lblReportText.TabIndex = 31;
            this.lblReportText.Text = "Report Type:";
            // 
            // btnUnsolvedTicket
            // 
            this.btnUnsolvedTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnsolvedTicket.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnsolvedTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnUnsolvedTicket.Location = new System.Drawing.Point(295, 171);
            this.btnUnsolvedTicket.Name = "btnUnsolvedTicket";
            this.btnUnsolvedTicket.Size = new System.Drawing.Size(172, 24);
            this.btnUnsolvedTicket.TabIndex = 32;
            this.btnUnsolvedTicket.Text = "Unsolved Tickets";
            this.btnUnsolvedTicket.UseVisualStyleBackColor = true;
            this.btnUnsolvedTicket.Click += new System.EventHandler(this.btnUnsolvedTicket_Click);
            // 
            // btnSolvedTickets
            // 
            this.btnSolvedTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSolvedTickets.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSolvedTickets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSolvedTickets.Location = new System.Drawing.Point(295, 215);
            this.btnSolvedTickets.Name = "btnSolvedTickets";
            this.btnSolvedTickets.Size = new System.Drawing.Size(172, 24);
            this.btnSolvedTickets.TabIndex = 33;
            this.btnSolvedTickets.Text = "Solved Tickets";
            this.btnSolvedTickets.UseVisualStyleBackColor = true;
            this.btnSolvedTickets.Click += new System.EventHandler(this.btnSolvedTickets_Click);
            // 
            // btnExistingTickets
            // 
            this.btnExistingTickets.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExistingTickets.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExistingTickets.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnExistingTickets.Location = new System.Drawing.Point(295, 263);
            this.btnExistingTickets.Name = "btnExistingTickets";
            this.btnExistingTickets.Size = new System.Drawing.Size(172, 24);
            this.btnExistingTickets.TabIndex = 34;
            this.btnExistingTickets.Text = "Existing Tickets";
            this.btnExistingTickets.UseVisualStyleBackColor = true;
            this.btnExistingTickets.Click += new System.EventHandler(this.btnExistingTickets_Click);
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
            // BtnViewReports
            // 
            this.BtnViewReports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnViewReports.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnViewReports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.BtnViewReports.Location = new System.Drawing.Point(295, 309);
            this.BtnViewReports.Name = "BtnViewReports";
            this.BtnViewReports.Size = new System.Drawing.Size(172, 24);
            this.BtnViewReports.TabIndex = 35;
            this.BtnViewReports.Text = "View Reports";
            this.BtnViewReports.UseVisualStyleBackColor = true;
            this.BtnViewReports.Click += new System.EventHandler(this.BtnViewReports_Click);
            // 
            // GenerateReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnViewReports);
            this.Controls.Add(this.btnExistingTickets);
            this.Controls.Add(this.btnSolvedTickets);
            this.Controls.Add(this.btnUnsolvedTicket);
            this.Controls.Add(this.lblReportText);
            this.Controls.Add(this.back);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.fullBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "GenerateReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GenerateReportForm";
            this.Load += new System.EventHandler(this.GenerateReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ImageList backButtonList;
        private System.Windows.Forms.Label lblReportText;
        private System.Windows.Forms.Button btnUnsolvedTicket;
        private System.Windows.Forms.Button btnSolvedTickets;
        private System.Windows.Forms.Button btnExistingTickets;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button BtnViewReports;
    }
}