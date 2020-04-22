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
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblContact = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.l = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.flowLayoutPanel3 = new System.Windows.Forms.FlowLayoutPanel();
            this.lblAssigned = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lblAddNotes = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnEmail = new System.Windows.Forms.Button();
            this.lblEdit = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.flowLayoutPanel1.SuspendLayout();
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
            this.minimizeBtn.Location = new System.Drawing.Point(522, 6);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(18, 26);
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
            this.fullBtn.Location = new System.Drawing.Point(544, 15);
            this.fullBtn.Margin = new System.Windows.Forms.Padding(2);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(15, 10);
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
            this.exitBtn.Location = new System.Drawing.Point(562, 7);
            this.exitBtn.Margin = new System.Windows.Forms.Padding(0);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(32, 26);
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
            this.back.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.back.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.back.ImageKey = "backbutton.png";
            this.back.ImageList = this.backButtonList;
            this.back.Location = new System.Drawing.Point(10, 11);
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
            this.flowLayoutPanel1.Controls.Add(this.lblDescription);
            this.flowLayoutPanel1.Controls.Add(this.richTextBox1);
            this.flowLayoutPanel1.Controls.Add(this.lblContact);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Controls.Add(this.label2);
            this.flowLayoutPanel1.Controls.Add(this.label3);
            this.flowLayoutPanel1.Controls.Add(this.l);
            this.flowLayoutPanel1.Controls.Add(this.listBox1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(10, 55);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(244, 301);
            this.flowLayoutPanel1.TabIndex = 32;
            this.flowLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // LblTicket
            // 
            this.LblTicket.AutoSize = true;
            this.LblTicket.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTicket.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LblTicket.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblTicket.Location = new System.Drawing.Point(2, 0);
            this.LblTicket.Margin = new System.Windows.Forms.Padding(2, 0, 0, 0);
            this.LblTicket.Name = "LblTicket";
            this.LblTicket.Size = new System.Drawing.Size(76, 15);
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
            this.LblID.Location = new System.Drawing.Point(80, 0);
            this.LblID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblID.Name = "LblID";
            this.LblID.Size = new System.Drawing.Size(20, 15);
            this.LblID.TabIndex = 1;
            this.LblID.Text = "ID";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblDescription.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.lblDescription, true);
            this.lblDescription.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblDescription.Location = new System.Drawing.Point(2, 15);
            this.lblDescription.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(62, 15);
            this.lblDescription.TabIndex = 4;
            this.lblDescription.Text = "Description";
            // 
            // lblContact
            // 
            this.lblContact.AutoSize = true;
            this.lblContact.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblContact.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.lblContact, true);
            this.lblContact.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblContact.Location = new System.Drawing.Point(2, 75);
            this.lblContact.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblContact.Name = "lblContact";
            this.lblContact.Size = new System.Drawing.Size(46, 15);
            this.lblContact.TabIndex = 7;
            this.lblContact.Text = "Contact";
            this.lblContact.Click += new System.EventHandler(this.lblContact_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.SetFlowBreak(this.label1, true);
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(2, 90);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 15);
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
            this.label2.Location = new System.Drawing.Point(2, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 15);
            this.label2.TabIndex = 9;
            this.label2.Text = "date";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel1.SetFlowBreak(this.label3, true);
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label3.Location = new System.Drawing.Point(2, 120);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 15);
            this.label3.TabIndex = 10;
            this.label3.Text = "Assigned To";
            // 
            // l
            // 
            this.l.AutoSize = true;
            this.l.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.SetFlowBreak(this.l, true);
            this.l.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.l.Location = new System.Drawing.Point(2, 135);
            this.l.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.l.Name = "l";
            this.l.Size = new System.Drawing.Size(29, 15);
            this.l.TabIndex = 11;
            this.l.Text = "user";
            this.l.Click += new System.EventHandler(this.l_Click);
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(2, 210);
            this.listBox1.Margin = new System.Windows.Forms.Padding(2);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(176, 69);
            this.listBox1.TabIndex = 12;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
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
            this.flowLayoutPanel3.Location = new System.Drawing.Point(258, 55);
            this.flowLayoutPanel3.Margin = new System.Windows.Forms.Padding(2);
            this.flowLayoutPanel3.Name = "flowLayoutPanel3";
            this.flowLayoutPanel3.Size = new System.Drawing.Size(324, 301);
            this.flowLayoutPanel3.TabIndex = 34;
            // 
            // lblAssigned
            // 
            this.lblAssigned.AutoSize = true;
            this.lblAssigned.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAssigned.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel3.SetFlowBreak(this.lblAssigned, true);
            this.lblAssigned.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAssigned.Location = new System.Drawing.Point(2, 0);
            this.lblAssigned.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAssigned.Name = "lblAssigned";
            this.lblAssigned.Size = new System.Drawing.Size(68, 15);
            this.lblAssigned.TabIndex = 0;
            this.lblAssigned.Text = "Assigned To";
            // 
            // comboBox1
            // 
            this.flowLayoutPanel3.SetFlowBreak(this.comboBox1, true);
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(2, 27);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(2);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(92, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // lblAddNotes
            // 
            this.lblAddNotes.AutoSize = true;
            this.flowLayoutPanel3.SetFlowBreak(this.lblAddNotes, true);
            this.lblAddNotes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblAddNotes.Location = new System.Drawing.Point(2, 50);
            this.lblAddNotes.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblAddNotes.Name = "lblAddNotes";
            this.lblAddNotes.Size = new System.Drawing.Size(57, 13);
            this.lblAddNotes.TabIndex = 2;
            this.lblAddNotes.Text = "Add Notes";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.textBox1.Location = new System.Drawing.Point(2, 76);
            this.textBox1.Margin = new System.Windows.Forms.Padding(2);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(186, 20);
            this.textBox1.TabIndex = 3;
            // 
            // btnSave
            // 
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.flowLayoutPanel3.SetFlowBreak(this.btnSave, true);
            this.btnSave.Location = new System.Drawing.Point(192, 76);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(56, 23);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // btnEmail
            // 
            this.btnEmail.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmail.Location = new System.Drawing.Point(2, 103);
            this.btnEmail.Margin = new System.Windows.Forms.Padding(2);
            this.btnEmail.Name = "btnEmail";
            this.btnEmail.Size = new System.Drawing.Size(91, 26);
            this.btnEmail.TabIndex = 5;
            this.btnEmail.Text = "Send Email";
            this.btnEmail.UseVisualStyleBackColor = true;
            // 
            // lblEdit
            // 
            this.lblEdit.AutoSize = true;
            this.lblEdit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblEdit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lblEdit.Location = new System.Drawing.Point(394, 40);
            this.lblEdit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEdit.Name = "lblEdit";
            this.lblEdit.Size = new System.Drawing.Size(60, 15);
            this.lblEdit.TabIndex = 36;
            this.lblEdit.Text = "Edit Ticket";
            // 
            // richTextBox1
            // 
            this.flowLayoutPanel1.SetFlowBreak(this.richTextBox1, true);
            this.richTextBox1.Location = new System.Drawing.Point(3, 48);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(100, 24);
            this.richTextBox1.TabIndex = 13;
            this.richTextBox1.Text = "";
            // 
            // ViewTicketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.lblEdit);
            this.Controls.Add(this.flowLayoutPanel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.back);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.fullBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ViewTicketForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewTicketForm";
            this.Load += new System.EventHandler(this.ViewTicketForm_Load);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
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
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel3;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblContact;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label l;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Label lblEdit;
        private System.Windows.Forms.Label lblAssigned;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblAddNotes;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnEmail;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}