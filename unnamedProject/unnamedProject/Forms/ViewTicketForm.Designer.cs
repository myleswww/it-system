namespace unnamedProject.Forms
{
    partial class ViewTicketForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewTicketForm));
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.back = new System.Windows.Forms.Button();
            this.backButtonList = new System.Windows.Forms.ImageList(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.LblTicket = new System.Windows.Forms.Label();
            this.LblID = new System.Windows.Forms.Label();
            this.LblName = new System.Windows.Forms.Label();
            this.TxtBxName = new System.Windows.Forms.TextBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.txtBxDescription = new System.Windows.Forms.TextBox();
            this.lblContact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.webBrowserViewTicket = new System.Windows.Forms.WebBrowser();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAssigned = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAddNotes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.lblOnline = new System.Windows.Forms.Label();
            this.lblEdit = new System.Windows.Forms.Label();
            this.flowLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel3.SuspendLayout();
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
            this.minimizeBtn.Location = new System.Drawing.Point(696, 8);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(24, 32);
            this.minimizeBtn.TabIndex = 21;
            this.minimizeBtn.Text = "-";
            this.minimizeBtn.UseVisualStyleBackColor = true;
            // 
            // fullBtn
            // 
            this.fullBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.fullBtn.FlatAppearance.BorderSize = 2;
            this.fullBtn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.fullBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.fullBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fullBtn.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.fullBtn.Location = new System.Drawing.Point(726, 18);
            this.fullBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(20, 12);
            this.fullBtn.TabIndex = 20;
            this.fullBtn.UseVisualStyleBackColor = true;
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
            this.exitBtn.Location = new System.Drawing.Point(749, 9);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(42, 32);
            this.exitBtn.TabIndex = 19;
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
            this.back.TabIndex = 31;
            this.back.UseVisualStyleBackColor = false;
            // 
            // backButtonList
            // 
            this.backButtonList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("backButtonList.ImageStream")));
            this.backButtonList.TransparentColor = System.Drawing.Color.Transparent;
            this.backButtonList.Images.SetKeyName(0, "icons8-rewind-button-round-80.png");
            this.backButtonList.Images.SetKeyName(1, "backbutton.png");
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.LblTicket);
            this.flowLayoutPanel1.Controls.Add(this.LblID);
            this.flowLayoutPanel1.Controls.Add(this.LblName);
            this.flowLayoutPanel1.Controls.Add(this.TxtBxName);
            this.flowLayoutPanel1.Controls.Add(this.lblDescription);
            this.flowLayoutPanel1.Controls.Add(this.txtBxDescription);
            this.flowLayoutPanel1.Controls.Add(this.lblContact);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.l);
            this.flowLayoutPanel1.Controls.Add(this.listBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(13, 68);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(250, 370);
            this.flowLayoutPanel1.TabIndex = 32;
            // 
            // LblTicket
            // 
            this.LblTicket.AutoSize = true;
            this.LblTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTicket.Location = new System.Drawing.Point(3, 0);
            this.LblTicket.Margin = new System.Windows.Forms.Padding(3, 0, 0, 0);
            this.LblTicket.Name = "LblTicket";
            this.LblTicket.Size = new System.Drawing.Size(99, 19);
            this.LblTicket.TabIndex = 0;
            this.LblTicket.Text = "Current Ticket";
            this.LblTicket.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LblID
            // 
            this.LblID.AutoSize = true;
            this.LblID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblID.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.LblID, true);
            this.LblID.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblID.Location = new System.Drawing.Point(105, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(23, 19);
            this.LblID.TabIndex = 1;
            this.LblID.Text = "ID";
            // 
            // LblName
            // 
            this.LblName.AutoSize = true;
            this.LblName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.LblName, true);
            this.LblName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblName.Location = new System.Drawing.Point(3, 19);
            this.LblName.Name = "LblName";
            this.LblName.Size = new System.Drawing.Size(47, 19);
            this.LblName.TabIndex = 3;
            this.LblName.Text = "Name";
            // 
            // TxtBxName
            // 
            this.TxtBxName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TxtBxName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.SetFlowBreak(this.TxtBxName, true);
            this.TxtBxName.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.TxtBxName.Location = new System.Drawing.Point(0, 41);
            this.TxtBxName.Margin = new System.Windows.Forms.Padding(0);
            this.TxtBxName.Name = "TxtBxName";
            this.TxtBxName.ReadOnly = true;
            this.TxtBxName.Size = new System.Drawing.Size(100, 22);
            this.TxtBxName.TabIndex = 2;
            this.TxtBxName.Text = "Name";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.lblDescription, true);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(3, 63);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(81, 19);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // txtBxDescription
            // 
            this.txtBxDescription.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtBxDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.SetFlowBreak(this.txtBxDescription, true);
            this.txtBxDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBxDescription.Location = new System.Drawing.Point(3, 94);
            this.txtBxDescription.Name = "txtBxDescription";
            this.txtBxDescription.Size = new System.Drawing.Size(100, 22);
            this.txtBxDescription.TabIndex = 5;
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.lblContact, true);
            this.lblContact.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContact.Location = new System.Drawing.Point(3, 119);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(58, 19);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.SetFlowBreak(this.label1, true);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(3, 138);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(103, 19);
            this.label1.TabIndex = 8;
            this.label1.Text = "Date Recieved";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.label2, true);
            this.label2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label2.Location = new System.Drawing.Point(3, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 19);
            this.label2.TabIndex = 9;
            this.label2.Text = "date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.label3, true);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(3, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 10;
            this.label3.Text = "Assigned To";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.SetFlowBreak(this.l, true);
            this.l.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l.Location = new System.Drawing.Point(3, 195);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(38, 19);
            this.l.TabIndex = 11;
            this.l.Text = "user";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 16;
            this.listBox1.Location = new System.Drawing.Point(3, 217);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(234, 84);
            this.listBox1.TabIndex = 12;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel2.Controls.Add(this.webBrowserViewTicket);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(269, 68);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(250, 370);
            this.flowLayoutPanel2.TabIndex = 33;
            // 
            // webBrowserViewTicket
            // 
            this.webBrowserViewTicket.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.webBrowserViewTicket.Location = new System.Drawing.Point(3, 3);
            this.webBrowserViewTicket.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowserViewTicket.Name = "webBrowserViewTicket";
            this.webBrowserViewTicket.Size = new System.Drawing.Size(250, 20);
            this.webBrowserViewTicket.TabIndex = 0;
            // 
            // flowLayoutPanel3
            // 
            this.flowLayoutPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel3.Controls.Add(this.lblAssigned);
            this.flowLayoutPanel3.Controls.Add(this.comboBox1);
            this.flowLayoutPanel3.Controls.Add(this.lblAddNotes);
            this.flowLayoutPanel3.Controls.Add(this.textBox1);
            this.flowLayoutPanel3.Controls.Add(this.btnSave);
            this.flowLayoutPanel3.Controls.Add(this.btnEmail);
            this.flowLayoutPanel3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.flowLayoutPanel3.Location = new System.Drawing.Point(525, 68);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(250, 370);
            this.flowLayoutPanel3.TabIndex = 34;
            // 
            // lblAssigned
            // 
            this.lblAssigned.AutoSize = true;
            this.lblAssigned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel3.SetFlowBreak(this.lblAssigned, true);
            this.lblAssigned.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAssigned.Location = new System.Drawing.Point(3, 0);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(89, 19);
            this.lblAssigned.TabIndex = 0;
            this.lblAssigned.Text = "Assigned To";
            // 
            // comboBox1
            // 
            this.flowLayoutPanel3.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(3, 33);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 1;
            // 
            // lblAddNotes
            // 
            this.lblAddNotes.AutoSize = true;
            this.flowLayoutPanel3.SetFlowBreak(this.lblAddNotes, true);
            this.lblAddNotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddNotes.Location = new System.Drawing.Point(3, 60);
            this.lblAddNotes.Name = "lblAddNotes";
            this.lblAddNotes.Size = new System.Drawing.Size(74, 17);
            this.lblAddNotes.TabIndex = 2;
            this.lblAddNotes.Text = "Add Notes";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(3, 80);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(246, 22);
            this.textBox1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel3.SetFlowBreak(this.btnSave, true);
            this.btnSave.Location = new System.Drawing.Point(3, 108);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 28);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEmail
            // 
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Location = new System.Drawing.Point(3, 146);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(121, 32);
            this.btnEmail.TabIndex = 5;
            this.btnEmail.Text = "Send Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // lblOnline
            // 
            this.lblOnline.AutoSize = true;
            this.lblOnline.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblOnline.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblOnline.Location = new System.Drawing.Point(269, 49);
            this.lblOnline.Name = "lblOnline";
            this.lblOnline.Size = new System.Drawing.Size(84, 19);
            this.lblOnline.TabIndex = 35;
            this.lblOnline.Text = "Online Help";
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdit.Location = new System.Drawing.Point(525, 49);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(76, 19);
            this.lblEdit.TabIndex = 36;
            this.lblEdit.Text = "Edit Ticket";
            // 
            // ViewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.lblOnline);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.fullBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ViewTicketForm";
            this.Text = "ViewTicketForm";
            this.Load += new System.EventHandler(this.ViewTicketForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel3.ResumeLayout(false);
            this.flowLayoutPanel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ImageList imageList2;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button back;
        private System.Windows.Forms.ImageList backButtonList;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Label LblTicket;
        private System.Windows.Forms.Label LblID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label LblName;
        private System.Windows.Forms.TextBox TxtBxName;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.TextBox txtBxDescription;
        private System.Windows.Forms.WebBrowser webBrowserViewTicket;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblOnline;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAddNotes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEmail;
    }
}