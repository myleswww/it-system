namespace unnamedProject
{
    partial class ViewReportForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewReportForm));
            this.LblDateTime = new System.Windows.Forms.Label();
            this.LblNum = new System.Windows.Forms.Label();
            this.LblNew = new System.Windows.Forms.Label();
            this.LblPercent = new System.Windows.Forms.Label();
            this.LblManagerID = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblReport = new System.Windows.Forms.Label();
            this.back = new System.Windows.Forms.Button();
            this.backButtonList = new System.Windows.Forms.ImageList(this.components);
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.SuspendLayout();
            // 
            // LblDateTime
            // 
            this.LblDateTime.AutoSize = true;
            this.LblDateTime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblDateTime.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDateTime.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblDateTime.Location = new System.Drawing.Point(530, 60);
            this.LblDateTime.Name = "LblDateTime";
            this.LblDateTime.Size = new System.Drawing.Size(41, 32);
            this.LblDateTime.TabIndex = 51;
            this.LblDateTime.Text = "Date:\r\nTime:";
            // 
            // LblNum
            // 
            this.LblNum.AutoSize = true;
            this.LblNum.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblNum.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNum.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNum.Location = new System.Drawing.Point(277, 140);
            this.LblNum.Name = "LblNum";
            this.LblNum.Size = new System.Drawing.Size(188, 16);
            this.LblNum.TabIndex = 50;
            this.LblNum.Text = "Number of Unsolved Tickets: ";
            // 
            // LblNew
            // 
            this.LblNew.AutoSize = true;
            this.LblNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblNew.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNew.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblNew.Location = new System.Drawing.Point(277, 317);
            this.LblNew.Name = "LblNew";
            this.LblNew.Size = new System.Drawing.Size(215, 16);
            this.LblNew.TabIndex = 49;
            this.LblNew.Text = "New Tickets in The Last 30 Days: ";
            // 
            // LblPercent
            // 
            this.LblPercent.AutoSize = true;
            this.LblPercent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblPercent.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblPercent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblPercent.Location = new System.Drawing.Point(277, 214);
            this.LblPercent.Name = "LblPercent";
            this.LblPercent.Size = new System.Drawing.Size(208, 16);
            this.LblPercent.TabIndex = 48;
            this.LblPercent.Text = "Percent of All Tickets Unsolved: ";
            // 
            // LblManagerID
            // 
            this.LblManagerID.AutoSize = true;
            this.LblManagerID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblManagerID.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblManagerID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblManagerID.Location = new System.Drawing.Point(277, 60);
            this.LblManagerID.Name = "LblManagerID";
            this.LblManagerID.Size = new System.Drawing.Size(91, 16);
            this.LblManagerID.TabIndex = 47;
            this.LblManagerID.Text = "Manager ID #";
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblID.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblID.Location = new System.Drawing.Point(63, 60);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(82, 16);
            this.LblID.TabIndex = 46;
            this.LblID.Text = "Report ID #";
            // 
            // LblReport
            // 
            this.LblReport.AutoSize = true;
            this.LblReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblReport.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblReport.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblReport.Location = new System.Drawing.Point(319, 25);
            this.LblReport.Name = "LblReport";
            this.LblReport.Size = new System.Drawing.Size(84, 16);
            this.LblReport.TabIndex = 45;
            this.LblReport.Text = "ReportLabel";
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
            this.back.Location = new System.Drawing.Point(8, 8);
            this.back.Margin = new System.Windows.Forms.Padding(4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(48, 48);
            this.back.TabIndex = 44;
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
            // minimizeBtn
            // 
            this.minimizeBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeBtn.FlatAppearance.BorderSize = 0;
            this.minimizeBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.minimizeBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.minimizeBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minimizeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minimizeBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.minimizeBtn.Location = new System.Drawing.Point(702, 3);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(21, 30);
            this.minimizeBtn.TabIndex = 43;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            this.minimizeBtn.Click += new System.EventHandler(this.minimizeBtn_Click);
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
            this.exitBtn.Location = new System.Drawing.Point(748, 4);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(38, 30);
            this.exitBtn.TabIndex = 41;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
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
            // ViewReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblDateTime);
            this.Controls.Add(this.LblNum);
            this.Controls.Add(this.LblNew);
            this.Controls.Add(this.LblPercent);
            this.Controls.Add(this.LblManagerID);
            this.Controls.Add(this.LblID);
            this.Controls.Add(this.LblReport);
            this.Controls.Add(this.back);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewReportForm";
            this.Load += new System.EventHandler(this.ViewReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblDateTime;
        private System.Windows.Forms.Label LblNum;
        private System.Windows.Forms.Label LblNew;
        private System.Windows.Forms.Label LblPercent;
        private System.Windows.Forms.Label LblManagerID;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.Label LblReport;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ImageList backButtonList;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}