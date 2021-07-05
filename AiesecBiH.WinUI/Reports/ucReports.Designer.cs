﻿
namespace AiesecBiH.WinUI.Reports
{
    partial class ucReports
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
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewReport = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvReports = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtSearchMandate = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(47, 208);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(233, 22);
            this.txtSearchName.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(33, 96);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 40);
            this.label4.TabIndex = 26;
            this.label4.Text = "Reports";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Name";
            // 
            // btnNewReport
            // 
            this.btnNewReport.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewReport.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewReport.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewReport.FlatAppearance.BorderSize = 0;
            this.btnNewReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewReport.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewReport.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnNewReport.Location = new System.Drawing.Point(968, 96);
            this.btnNewReport.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewReport.Name = "btnNewReport";
            this.btnNewReport.Size = new System.Drawing.Size(200, 49);
            this.btnNewReport.TabIndex = 23;
            this.btnNewReport.Text = "New";
            this.btnNewReport.UseVisualStyleBackColor = false;
            this.btnNewReport.Click += new System.EventHandler(this.btnNewReport_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(968, 186);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 49);
            this.btnSearch.TabIndex = 21;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvReports);
            this.groupBox1.Location = new System.Drawing.Point(41, 255);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1127, 389);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reports";
            // 
            // dgvReports
            // 
            this.dgvReports.AllowUserToAddRows = false;
            this.dgvReports.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReports.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReports.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dgvReports.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvReports.Location = new System.Drawing.Point(5, 20);
            this.dgvReports.Margin = new System.Windows.Forms.Padding(5);
            this.dgvReports.Name = "dgvReports";
            this.dgvReports.ReadOnly = true;
            this.dgvReports.RowHeadersWidth = 51;
            this.dgvReports.Size = new System.Drawing.Size(1117, 364);
            this.dgvReports.TabIndex = 0;
            this.dgvReports.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvReports_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // txtSearchMandate
            // 
            this.txtSearchMandate.Location = new System.Drawing.Point(305, 208);
            this.txtSearchMandate.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchMandate.Name = "txtSearchMandate";
            this.txtSearchMandate.Size = new System.Drawing.Size(233, 22);
            this.txtSearchMandate.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(301, 186);
            this.label1.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 17);
            this.label1.TabIndex = 28;
            this.label1.Text = "Mandate";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(963, 654);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(200, 49);
            this.btnDelete.TabIndex = 30;
            this.btnDelete.Text = "Delete Selected Row";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // ucReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtSearchMandate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSearchName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewReport);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucReports";
            this.Size = new System.Drawing.Size(1200, 738);
            this.Load += new System.EventHandler(this.ucReports_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvReports)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewReport;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSearchMandate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvReports;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.Button btnDelete;
    }
}
