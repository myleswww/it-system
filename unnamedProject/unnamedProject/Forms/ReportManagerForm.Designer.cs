﻿namespace unnamedProject.Forms
{
    partial class ReportManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportManagerForm));
            this.buttonCollapse = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.mainPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.openTab = new System.Windows.Forms.Button();
            this.closedTab = new System.Windows.Forms.Button();
            this.FAPTab = new System.Windows.Forms.Button();
            this.tabRrports = new System.Windows.Forms.Button();
            this.ticketTable = new System.Windows.Forms.TableLayoutPanel();
            this.optionPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.problemBtn = new System.Windows.Forms.Button();
            this.reportBtn = new System.Windows.Forms.Button();
            this.settingsBtn = new System.Windows.Forms.Button();
            this.logOut = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            this.optionPanel.SuspendLayout();
            this.SuspendLayout();
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
            this.buttonCollapse.Location = new System.Drawing.Point(12, 12);
            this.buttonCollapse.Name = "buttonCollapse";
            this.buttonCollapse.Size = new System.Drawing.Size(70, 46);
            this.buttonCollapse.TabIndex = 4;
            this.buttonCollapse.UseVisualStyleBackColor = false;
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
            this.minimizeBtn.Location = new System.Drawing.Point(962, 7);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 32);
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
            this.fullBtn.Location = new System.Drawing.Point(992, 18);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(20, 12);
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
            this.exitBtn.Location = new System.Drawing.Point(1015, 9);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(43, 32);
            this.exitBtn.TabIndex = 19;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click_1);
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BackColor = System.Drawing.Color.Lime;
            this.mainPanel.Controls.Add(this.openTab);
            this.mainPanel.Controls.Add(this.closedTab);
            this.mainPanel.Controls.Add(this.FAPTab);
            this.mainPanel.Controls.Add(this.tabRrports);
            this.mainPanel.Controls.Add(this.ticketTable);
            this.mainPanel.Location = new System.Drawing.Point(-5, 64);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1072, 498);
            this.mainPanel.TabIndex = 23;
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
            // 
            // tabRrports
            // 
            this.tabRrports.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.tabRrports.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.tabRrports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.tabRrports.Font = new System.Drawing.Font("Britannic Bold", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabRrports.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.tabRrports.Location = new System.Drawing.Point(227, 0);
            this.tabRrports.Margin = new System.Windows.Forms.Padding(0);
            this.tabRrports.Name = "tabRrports";
            this.tabRrports.Size = new System.Drawing.Size(75, 29);
            this.tabRrports.TabIndex = 9;
            this.tabRrports.Text = "Reports";
            this.tabRrports.UseVisualStyleBackColor = true;
            // 
            // ticketTable
            // 
            this.ticketTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ticketTable.BackColor = System.Drawing.Color.Yellow;
            this.ticketTable.ColumnCount = 2;
            this.ticketTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ticketTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ticketTable.Location = new System.Drawing.Point(3, 32);
            this.ticketTable.Name = "ticketTable";
            this.ticketTable.RowCount = 2;
            this.ticketTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ticketTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.ticketTable.Size = new System.Drawing.Size(1065, 466);
            this.ticketTable.TabIndex = 11;
            // 
            // optionPanel
            // 
            this.optionPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.optionPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(188)))), ((int)(((byte)(94)))));
            this.optionPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.optionPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.optionPanel.Controls.Add(this.problemBtn);
            this.optionPanel.Controls.Add(this.reportBtn);
            this.optionPanel.Controls.Add(this.settingsBtn);
            this.optionPanel.Controls.Add(this.logOut);
            this.optionPanel.Location = new System.Drawing.Point(-2, 61);
            this.optionPanel.Margin = new System.Windows.Forms.Padding(0);
            this.optionPanel.Name = "optionPanel";
            this.optionPanel.Size = new System.Drawing.Size(214, 501);
            this.optionPanel.TabIndex = 24;
            this.optionPanel.Visible = false;
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
            this.problemBtn.Location = new System.Drawing.Point(0, 1);
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
            this.reportBtn.Location = new System.Drawing.Point(0, 31);
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
            this.settingsBtn.Location = new System.Drawing.Point(0, 61);
            this.settingsBtn.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.settingsBtn.Name = "settingsBtn";
            this.settingsBtn.Size = new System.Drawing.Size(214, 28);
            this.settingsBtn.TabIndex = 5;
            this.settingsBtn.Text = "Settings";
            this.settingsBtn.UseVisualStyleBackColor = false;
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
            this.logOut.Location = new System.Drawing.Point(0, 91);
            this.logOut.Margin = new System.Windows.Forms.Padding(0, 1, 0, 1);
            this.logOut.Name = "logOut";
            this.logOut.Size = new System.Drawing.Size(214, 28);
            this.logOut.TabIndex = 0;
            this.logOut.Text = "Log Out";
            this.logOut.UseVisualStyleBackColor = false;
            // 
            // ReportManagerForm
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
            this.Controls.Add(this.mainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportManagerForm";
            this.Text = "ReportManagerForm";
            this.Load += new System.EventHandler(this.ReportManagerForm_Load);
            this.mainPanel.ResumeLayout(false);
            this.optionPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonCollapse;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.FlowLayoutPanel mainPanel;
        private System.Windows.Forms.Button openTab;
        private System.Windows.Forms.Button closedTab;
        private System.Windows.Forms.Button FAPTab;
        private System.Windows.Forms.Button tabRrports;
        private System.Windows.Forms.TableLayoutPanel ticketTable;
        private System.Windows.Forms.FlowLayoutPanel optionPanel;
        private System.Windows.Forms.Button problemBtn;
        private System.Windows.Forms.Button reportBtn;
        private System.Windows.Forms.Button settingsBtn;
        private System.Windows.Forms.Button logOut;
    }
}