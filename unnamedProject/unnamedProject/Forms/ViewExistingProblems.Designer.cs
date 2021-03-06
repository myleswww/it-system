using System;

namespace unnamedProject
{
    partial class ViewExistingProblems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewExistingProblems));
            this.back = new System.Windows.Forms.Button();
            this.backButtonList = new System.Windows.Forms.ImageList(this.components);
            this.minimizeBtn = new System.Windows.Forms.Button();
            this.fullBtn = new System.Windows.Forms.Button();
            this.exitBtn = new System.Windows.Forms.Button();
            this.LstBxProblems = new System.Windows.Forms.ListBox();
            this.LblProblems = new System.Windows.Forms.Label();
            this.SuspendLayout();
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
            this.back.Location = new System.Drawing.Point(13, 14);
            this.back.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.back.Name = "back";
            this.back.Size = new System.Drawing.Size(64, 59);
            this.back.TabIndex = 34;
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
            this.minimizeBtn.Location = new System.Drawing.Point(707, 7);
            this.minimizeBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.minimizeBtn.Name = "minimizeBtn";
            this.minimizeBtn.Size = new System.Drawing.Size(21, 30);
            this.minimizeBtn.TabIndex = 33;
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
            this.fullBtn.Location = new System.Drawing.Point(733, 18);
            this.fullBtn.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.fullBtn.Name = "fullBtn";
            this.fullBtn.Size = new System.Drawing.Size(19, 11);
            this.fullBtn.TabIndex = 32;
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
            this.exitBtn.Size = new System.Drawing.Size(37, 30);
            this.exitBtn.TabIndex = 31;
            this.exitBtn.Text = "X";
            this.exitBtn.UseVisualStyleBackColor = true;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // LstBxProblems
            // 
            this.LstBxProblems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LstBxProblems.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LstBxProblems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LstBxProblems.FormattingEnabled = true;
            this.LstBxProblems.ItemHeight = 16;
            this.LstBxProblems.Location = new System.Drawing.Point(12, 68);
            this.LstBxProblems.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.LstBxProblems.Name = "LstBxProblems";
            this.LstBxProblems.Size = new System.Drawing.Size(779, 372);
            this.LstBxProblems.TabIndex = 35;
            this.LstBxProblems.SelectedIndexChanged += new System.EventHandler(this.LstBxProblems_SelectedIndexChanged);
            // 
            // LblProblems
            // 
            this.LblProblems.AutoSize = true;
            this.LblProblems.Font = new System.Drawing.Font("Britannic Bold", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblProblems.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.LblProblems.Location = new System.Drawing.Point(275, 18);
            this.LblProblems.Name = "LblProblems";
            this.LblProblems.Size = new System.Drawing.Size(236, 31);
            this.LblProblems.TabIndex = 36;
            this.LblProblems.Text = "Existing Problems";
            // 
            // ViewExistingProblems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LblProblems);
            this.Controls.Add(this.LstBxProblems);
            this.Controls.Add(this.back);
            this.Controls.Add(this.minimizeBtn);
            this.Controls.Add(this.fullBtn);
            this.Controls.Add(this.exitBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "ViewExistingProblems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ViewExistingProblems";
            this.Load += new System.EventHandler(this.ViewExistingProblems_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Button back;
        private System.Windows.Forms.Button minimizeBtn;
        private System.Windows.Forms.Button fullBtn;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ImageList backButtonList;
        private System.Windows.Forms.ListBox LstBxProblems;
        private System.Windows.Forms.Label LblProblems;
    }
}