﻿namespace E_Barangay.Forms
{
    partial class BarangayClearance
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.officerOption = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.Purpose = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.IssuedOn = new System.Windows.Forms.DateTimePicker();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.IdGroup = new System.Windows.Forms.GroupBox();
            this.AssignBtn = new System.Windows.Forms.Button();
            this.IDField = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.extText = new System.Windows.Forms.TextBox();
            this.lastText = new System.Windows.Forms.TextBox();
            this.middleText = new System.Windows.Forms.TextBox();
            this.SexOption = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.firstText = new System.Windows.Forms.TextBox();
            this.CStatusOption = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Address = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ORIssueDate = new System.Windows.Forms.DateTimePicker();
            this.OrValidityDate = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.OrNo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.printing = new E_Barangay.Forms.Printing();
            this.panel1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.IdGroup.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.groupBox4);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.ResetBtn);
            this.panel1.Controls.Add(this.IdGroup);
            this.panel1.Controls.Add(this.groupBox3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(352, 690);
            this.panel1.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.officerOption);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(12, 525);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(330, 55);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Signature";
            // 
            // officerOption
            // 
            this.officerOption.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.officerOption.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.officerOption.FormattingEnabled = true;
            this.officerOption.Location = new System.Drawing.Point(107, 19);
            this.officerOption.Name = "officerOption";
            this.officerOption.Size = new System.Drawing.Size(217, 21);
            this.officerOption.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(6, 18);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Officer of the Day:";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.Purpose);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.IssuedOn);
            this.groupBox2.Location = new System.Drawing.Point(12, 334);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 76);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "MISC";
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(6, 16);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 20);
            this.label12.TabIndex = 28;
            this.label12.Text = "Purpose:";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Purpose
            // 
            this.Purpose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Purpose.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Purpose.Location = new System.Drawing.Point(92, 17);
            this.Purpose.Name = "Purpose";
            this.Purpose.Size = new System.Drawing.Size(232, 20);
            this.Purpose.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(6, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Issued On:";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // IssuedOn
            // 
            this.IssuedOn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IssuedOn.CustomFormat = "MMMM dd, yyyy";
            this.IssuedOn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IssuedOn.Location = new System.Drawing.Point(92, 43);
            this.IssuedOn.Name = "IssuedOn";
            this.IssuedOn.Size = new System.Drawing.Size(232, 20);
            this.IssuedOn.TabIndex = 2;
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(126, 653);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(100, 25);
            this.ResetBtn.TabIndex = 6;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // IdGroup
            // 
            this.IdGroup.Controls.Add(this.AssignBtn);
            this.IdGroup.Controls.Add(this.IDField);
            this.IdGroup.Location = new System.Drawing.Point(12, 12);
            this.IdGroup.Name = "IdGroup";
            this.IdGroup.Size = new System.Drawing.Size(330, 77);
            this.IdGroup.TabIndex = 1;
            this.IdGroup.TabStop = false;
            this.IdGroup.Text = "User ID";
            // 
            // AssignBtn
            // 
            this.AssignBtn.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.AssignBtn.Location = new System.Drawing.Point(128, 45);
            this.AssignBtn.Name = "AssignBtn";
            this.AssignBtn.Size = new System.Drawing.Size(75, 23);
            this.AssignBtn.TabIndex = 4;
            this.AssignBtn.Text = "Assign";
            this.AssignBtn.UseVisualStyleBackColor = true;
            this.AssignBtn.Click += new System.EventHandler(this.AssignBtn_Click);
            // 
            // IDField
            // 
            this.IDField.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.IDField.Location = new System.Drawing.Point(6, 19);
            this.IDField.MaxLength = 10;
            this.IDField.Name = "IDField";
            this.IDField.Size = new System.Drawing.Size(318, 20);
            this.IDField.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.label13);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.extText);
            this.groupBox3.Controls.Add(this.lastText);
            this.groupBox3.Controls.Add(this.middleText);
            this.groupBox3.Controls.Add(this.SexOption);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.Age);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.firstText);
            this.groupBox3.Controls.Add(this.CStatusOption);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.Address);
            this.groupBox3.Location = new System.Drawing.Point(12, 95);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(330, 233);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "DETAILS";
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(6, 95);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 20);
            this.label14.TabIndex = 34;
            this.label14.Text = "Extension:";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(6, 69);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 20);
            this.label13.TabIndex = 33;
            this.label13.Text = "Last Name:";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(6, 43);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 20);
            this.label10.TabIndex = 32;
            this.label10.Text = "Middle Name:";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // extText
            // 
            this.extText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.extText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.extText.Location = new System.Drawing.Point(92, 95);
            this.extText.Name = "extText";
            this.extText.Size = new System.Drawing.Size(232, 20);
            this.extText.TabIndex = 4;
            // 
            // lastText
            // 
            this.lastText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lastText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.lastText.Location = new System.Drawing.Point(92, 69);
            this.lastText.Name = "lastText";
            this.lastText.Size = new System.Drawing.Size(232, 20);
            this.lastText.TabIndex = 3;
            // 
            // middleText
            // 
            this.middleText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.middleText.Location = new System.Drawing.Point(92, 43);
            this.middleText.Name = "middleText";
            this.middleText.Size = new System.Drawing.Size(232, 20);
            this.middleText.TabIndex = 2;
            // 
            // SexOption
            // 
            this.SexOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SexOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SexOption.FormattingEnabled = true;
            this.SexOption.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.SexOption.Location = new System.Drawing.Point(92, 173);
            this.SexOption.Name = "SexOption";
            this.SexOption.Size = new System.Drawing.Size(232, 21);
            this.SexOption.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(6, 173);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 28;
            this.label6.Text = "Sex";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(6, 121);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 26;
            this.label11.Text = "Age:";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Age
            // 
            this.Age.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Age.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.Age.Location = new System.Drawing.Point(92, 121);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(232, 20);
            this.Age.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Full Name:";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(6, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 20;
            this.label4.Text = "Civil Status";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // firstText
            // 
            this.firstText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.firstText.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.firstText.Location = new System.Drawing.Point(92, 17);
            this.firstText.Name = "firstText";
            this.firstText.Size = new System.Drawing.Size(232, 20);
            this.firstText.TabIndex = 1;
            // 
            // CStatusOption
            // 
            this.CStatusOption.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CStatusOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CStatusOption.FormattingEnabled = true;
            this.CStatusOption.Items.AddRange(new object[] {
            "Single",
            "Married"});
            this.CStatusOption.Location = new System.Drawing.Point(92, 200);
            this.CStatusOption.Name = "CStatusOption";
            this.CStatusOption.Size = new System.Drawing.Size(232, 21);
            this.CStatusOption.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(6, 147);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Address
            // 
            this.Address.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Address.Location = new System.Drawing.Point(92, 147);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(232, 20);
            this.Address.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ORIssueDate);
            this.groupBox1.Controls.Add(this.OrValidityDate);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.OrNo);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(12, 416);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(330, 103);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OR";
            // 
            // ORIssueDate
            // 
            this.ORIssueDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ORIssueDate.CustomFormat = "MMMM dd, yyyy";
            this.ORIssueDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ORIssueDate.Location = new System.Drawing.Point(92, 43);
            this.ORIssueDate.Name = "ORIssueDate";
            this.ORIssueDate.Size = new System.Drawing.Size(232, 20);
            this.ORIssueDate.TabIndex = 2;
            // 
            // OrValidityDate
            // 
            this.OrValidityDate.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrValidityDate.CustomFormat = "MMMM dd, yyyy";
            this.OrValidityDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.OrValidityDate.Location = new System.Drawing.Point(92, 69);
            this.OrValidityDate.Name = "OrValidityDate";
            this.OrValidityDate.Size = new System.Drawing.Size(232, 20);
            this.OrValidityDate.TabIndex = 3;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(6, 70);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "VALIDITY:";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(6, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "Issued On:";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // OrNo
            // 
            this.OrNo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrNo.Location = new System.Drawing.Point(92, 17);
            this.OrNo.MaxLength = 13;
            this.OrNo.Name = "OrNo";
            this.OrNo.Size = new System.Drawing.Size(232, 20);
            this.OrNo.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "ORNO:";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // printing
            // 
            this.printing.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.printing.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.printing.Dock = System.Windows.Forms.DockStyle.Right;
            this.printing.Location = new System.Drawing.Point(352, 0);
            this.printing.Name = "printing";
            this.printing.Size = new System.Drawing.Size(562, 690);
            this.printing.TabIndex = 0;
            // 
            // BarangayClearance
            // 
            this.AcceptButton = this.AssignBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 690);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.printing);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "BarangayClearance";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Barangay Clearcance";
            this.Load += new System.EventHandler(this.BarangayClearanceForm_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BarangayClearance_KeyDown);
            this.panel1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.IdGroup.ResumeLayout(false);
            this.IdGroup.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker IssuedOn;
        private System.Windows.Forms.TextBox Address;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstText;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker OrValidityDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox OrNo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CStatusOption;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox Age;
        private System.Windows.Forms.TextBox Purpose;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DateTimePicker ORIssueDate;
        private System.Windows.Forms.GroupBox IdGroup;
        private System.Windows.Forms.Button AssignBtn;
        private System.Windows.Forms.TextBox IDField;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox SexOption;
        private System.Windows.Forms.Label label6;
        private Printing printing;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox officerOption;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox extText;
        private System.Windows.Forms.TextBox lastText;
        private System.Windows.Forms.TextBox middleText;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label10;
    }
}