
namespace AiesecBiH.WinUI.FunctionalFields
{
    partial class ucFunctionalFields
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
            this.txtSearchFFName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnNewFunctField = new System.Windows.Forms.Button();
            this.txtSearchFFAbr = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvFunctionalFields = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkActiveOnly = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionalFields)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchFFName
            // 
            this.txtSearchFFName.Location = new System.Drawing.Point(27, 182);
            this.txtSearchFFName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchFFName.Name = "txtSearchFFName";
            this.txtSearchFFName.Size = new System.Drawing.Size(231, 20);
            this.txtSearchFFName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(21, 86);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(188, 31);
            this.label4.TabIndex = 17;
            this.label4.Text = "Functional Fields";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(287, 159);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Abbrevation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 159);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Name";
            // 
            // btnNewFunctField
            // 
            this.btnNewFunctField.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewFunctField.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewFunctField.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewFunctField.FlatAppearance.BorderSize = 0;
            this.btnNewFunctField.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewFunctField.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewFunctField.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnNewFunctField.Location = new System.Drawing.Point(722, 86);
            this.btnNewFunctField.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewFunctField.Name = "btnNewFunctField";
            this.btnNewFunctField.Size = new System.Drawing.Size(150, 40);
            this.btnNewFunctField.TabIndex = 14;
            this.btnNewFunctField.Text = "New";
            this.btnNewFunctField.UseVisualStyleBackColor = false;
            this.btnNewFunctField.Click += new System.EventHandler(this.btnNewFunctField_Click);
            // 
            // txtSearchFFAbr
            // 
            this.txtSearchFFAbr.Location = new System.Drawing.Point(291, 185);
            this.txtSearchFFAbr.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchFFAbr.Name = "txtSearchFFAbr";
            this.txtSearchFFAbr.Size = new System.Drawing.Size(220, 20);
            this.txtSearchFFAbr.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(722, 159);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFunctionalFields);
            this.groupBox1.Location = new System.Drawing.Point(27, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(845, 316);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Functional Fields";
            // 
            // dgvFunctionalFields
            // 
            this.dgvFunctionalFields.AllowUserToAddRows = false;
            this.dgvFunctionalFields.AllowUserToDeleteRows = false;
            this.dgvFunctionalFields.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFunctionalFields.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunctionalFields.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id});
            this.dgvFunctionalFields.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFunctionalFields.Location = new System.Drawing.Point(4, 17);
            this.dgvFunctionalFields.Margin = new System.Windows.Forms.Padding(4);
            this.dgvFunctionalFields.Name = "dgvFunctionalFields";
            this.dgvFunctionalFields.ReadOnly = true;
            this.dgvFunctionalFields.Size = new System.Drawing.Size(837, 295);
            this.dgvFunctionalFields.TabIndex = 0;
            this.dgvFunctionalFields.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFunctionalFields_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // chkActiveOnly
            // 
            this.chkActiveOnly.AutoSize = true;
            this.chkActiveOnly.Location = new System.Drawing.Point(557, 184);
            this.chkActiveOnly.Name = "chkActiveOnly";
            this.chkActiveOnly.Size = new System.Drawing.Size(80, 17);
            this.chkActiveOnly.TabIndex = 19;
            this.chkActiveOnly.Text = "Active Only";
            this.chkActiveOnly.UseVisualStyleBackColor = true;
            // 
            // ucFunctionalFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.chkActiveOnly);
            this.Controls.Add(this.txtSearchFFName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnNewFunctField);
            this.Controls.Add(this.txtSearchFFAbr);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Name = "ucFunctionalFields";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.ucFunctionalFields_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctionalFields)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchFFName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnNewFunctField;
        private System.Windows.Forms.TextBox txtSearchFFAbr;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvFunctionalFields;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.CheckBox chkActiveOnly;
    }
}
