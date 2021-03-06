﻿using E_Barangay.Class;

namespace E_Barangay.Forms
{
    partial class QueryControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QueryControl));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ResultTxt = new System.Windows.Forms.Label();
            this.CreateBtn = new System.Windows.Forms.Button();
            this.InspectBtn = new System.Windows.Forms.Button();
            this.ModifyBtn = new System.Windows.Forms.Button();
            this.SearchBox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.adSearchBtn = new System.Windows.Forms.Button();
            this.DataTable = new E_Barangay.Class.CustomDataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idNumCol = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ResultTxt
            // 
            this.ResultTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ResultTxt.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ResultTxt.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ResultTxt.ForeColor = System.Drawing.Color.Black;
            this.ResultTxt.Location = new System.Drawing.Point(6, 16);
            this.ResultTxt.Name = "ResultTxt";
            this.ResultTxt.Size = new System.Drawing.Size(231, 18);
            this.ResultTxt.TabIndex = 9;
            this.ResultTxt.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CreateBtn
            // 
            this.CreateBtn.BackColor = System.Drawing.Color.LightGray;
            this.CreateBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.CreateBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CreateBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBtn.ForeColor = System.Drawing.Color.Black;
            this.CreateBtn.Image = ((System.Drawing.Image)(resources.GetObject("CreateBtn.Image")));
            this.CreateBtn.Location = new System.Drawing.Point(171, 47);
            this.CreateBtn.Name = "CreateBtn";
            this.CreateBtn.Size = new System.Drawing.Size(80, 35);
            this.CreateBtn.TabIndex = 5;
            this.CreateBtn.Text = "Create";
            this.CreateBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.CreateBtn.UseVisualStyleBackColor = false;
            this.CreateBtn.Click += new System.EventHandler(this.CreateBtn_Click);
            // 
            // InspectBtn
            // 
            this.InspectBtn.BackColor = System.Drawing.Color.LightGray;
            this.InspectBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.InspectBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.InspectBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InspectBtn.ForeColor = System.Drawing.Color.Black;
            this.InspectBtn.Image = ((System.Drawing.Image)(resources.GetObject("InspectBtn.Image")));
            this.InspectBtn.Location = new System.Drawing.Point(8, 47);
            this.InspectBtn.Name = "InspectBtn";
            this.InspectBtn.Size = new System.Drawing.Size(83, 35);
            this.InspectBtn.TabIndex = 3;
            this.InspectBtn.Text = "Inspect";
            this.InspectBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.InspectBtn.UseVisualStyleBackColor = false;
            this.InspectBtn.Click += new System.EventHandler(this.InspectBtn_Click);
            // 
            // ModifyBtn
            // 
            this.ModifyBtn.BackColor = System.Drawing.Color.LightGray;
            this.ModifyBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.ModifyBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ModifyBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ModifyBtn.ForeColor = System.Drawing.Color.Black;
            this.ModifyBtn.Image = ((System.Drawing.Image)(resources.GetObject("ModifyBtn.Image")));
            this.ModifyBtn.Location = new System.Drawing.Point(91, 47);
            this.ModifyBtn.Name = "ModifyBtn";
            this.ModifyBtn.Size = new System.Drawing.Size(80, 35);
            this.ModifyBtn.TabIndex = 4;
            this.ModifyBtn.Text = "Modify";
            this.ModifyBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ModifyBtn.UseVisualStyleBackColor = false;
            this.ModifyBtn.Click += new System.EventHandler(this.ModifyBtn_Click);
            // 
            // SearchBox
            // 
            this.SearchBox.AcceptsReturn = true;
            this.SearchBox.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.SearchBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.SearchBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SearchBox.ForeColor = System.Drawing.Color.Black;
            this.SearchBox.Location = new System.Drawing.Point(8, 14);
            this.SearchBox.Name = "SearchBox";
            this.SearchBox.Size = new System.Drawing.Size(208, 22);
            this.SearchBox.TabIndex = 0;
            this.SearchBox.TextChanged += new System.EventHandler(this.SearchBox_TextChanged);
            this.SearchBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SearchBox_KeyDown);
            // 
            // SearchBtn
            // 
            this.SearchBtn.BackColor = System.Drawing.Color.Transparent;
            this.SearchBtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.SearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.SearchBtn.FlatAppearance.BorderSize = 0;
            this.SearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SearchBtn.ForeColor = System.Drawing.Color.White;
            this.SearchBtn.Image = ((System.Drawing.Image)(resources.GetObject("SearchBtn.Image")));
            this.SearchBtn.Location = new System.Drawing.Point(226, 7);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(23, 28);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.TabStop = false;
            this.SearchBtn.UseVisualStyleBackColor = false;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.Location = new System.Drawing.Point(8, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 1);
            this.panel1.TabIndex = 11;
            // 
            // adSearchBtn
            // 
            this.adSearchBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.adSearchBtn.BackColor = System.Drawing.Color.LightGray;
            this.adSearchBtn.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.adSearchBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.adSearchBtn.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adSearchBtn.ForeColor = System.Drawing.Color.Black;
            this.adSearchBtn.Location = new System.Drawing.Point(606, 9);
            this.adSearchBtn.Name = "adSearchBtn";
            this.adSearchBtn.Size = new System.Drawing.Size(243, 35);
            this.adSearchBtn.TabIndex = 12;
            this.adSearchBtn.Text = "Advanced Search";
            this.adSearchBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adSearchBtn.UseVisualStyleBackColor = false;
            this.adSearchBtn.Click += new System.EventHandler(this.adSearchBtn_Click);
            // 
            // DataTable
            // 
            this.DataTable.AllowUserToAddRows = false;
            this.DataTable.AllowUserToDeleteRows = false;
            this.DataTable.AllowUserToResizeColumns = false;
            this.DataTable.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataTable.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataTable.BackgroundColor = System.Drawing.SystemColors.ControlDark;
            this.DataTable.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataTable.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataTable.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.idNumCol,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataTable.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataTable.EnableHeadersVisualStyles = false;
            this.DataTable.GridColor = System.Drawing.Color.White;
            this.DataTable.Location = new System.Drawing.Point(8, 94);
            this.DataTable.MultiSelect = false;
            this.DataTable.Name = "DataTable";
            this.DataTable.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataTable.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataTable.RowHeadersVisible = false;
            this.DataTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataTable.Size = new System.Drawing.Size(841, 432);
            this.DataTable.StandardTab = true;
            this.DataTable.TabIndex = 2;
            this.DataTable.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DataTable_CellMouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ResultTxt);
            this.groupBox1.Font = new System.Drawing.Font("Times New Roman", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(606, 47);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(243, 41);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Total Entries";
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 200;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column1.Visible = false;
            this.Column1.Width = 200;
            // 
            // idNumCol
            // 
            this.idNumCol.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.idNumCol.HeaderText = "Id Number";
            this.idNumCol.Name = "idNumCol";
            this.idNumCol.ReadOnly = true;
            this.idNumCol.Width = 86;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Name";
            this.Column2.MinimumWidth = 200;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column3.HeaderText = "Address";
            this.Column3.MinimumWidth = 100;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // QueryControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.adSearchBtn);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CreateBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.InspectBtn);
            this.Controls.Add(this.DataTable);
            this.Controls.Add(this.ModifyBtn);
            this.Controls.Add(this.SearchBox);
            this.Name = "QueryControl";
            this.Size = new System.Drawing.Size(856, 536);
            this.Load += new System.EventHandler(this.QueryControl_Load);
            this.Enter += new System.EventHandler(this.QueryControl_Enter);
            ((System.ComponentModel.ISupportInitialize)(this.DataTable)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ModifyBtn;
        CustomDataGridView DataTable;
        //private System.Windows.Forms.DataGridView DataTable;
        private System.Windows.Forms.Button InspectBtn;
        private System.Windows.Forms.Label ResultTxt;
        private System.Windows.Forms.Button CreateBtn;
        private System.Windows.Forms.TextBox SearchBox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button adSearchBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idNumCol;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}
