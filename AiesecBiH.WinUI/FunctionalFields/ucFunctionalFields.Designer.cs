
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
            this.txtSearchFFName.Location = new System.Drawing.Point(36, 224);
            this.txtSearchFFName.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchFFName.Name = "txtSearchFFName";
            this.txtSearchFFName.Size = new System.Drawing.Size(307, 22);
            this.txtSearchFFName.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(28, 106);
            this.label4.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(239, 40);
            this.label4.TabIndex = 17;
            this.label4.Text = "Functional Fields";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(368, 196);
            this.label3.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 16;
            this.label3.Text = "Abbrevation";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 196);
            this.label2.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
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
            this.btnNewFunctField.Location = new System.Drawing.Point(963, 106);
            this.btnNewFunctField.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewFunctField.Name = "btnNewFunctField";
            this.btnNewFunctField.Size = new System.Drawing.Size(200, 49);
            this.btnNewFunctField.TabIndex = 14;
            this.btnNewFunctField.Text = "New";
            this.btnNewFunctField.UseVisualStyleBackColor = false;
            this.btnNewFunctField.Click += new System.EventHandler(this.btnNewFunctField_Click);
            // 
            // txtSearchFFAbr
            // 
            this.txtSearchFFAbr.Location = new System.Drawing.Point(372, 224);
            this.txtSearchFFAbr.Margin = new System.Windows.Forms.Padding(5);
            this.txtSearchFFAbr.Name = "txtSearchFFAbr";
            this.txtSearchFFAbr.Size = new System.Drawing.Size(292, 22);
            this.txtSearchFFAbr.TabIndex = 13;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(963, 196);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 49);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvFunctionalFields);
            this.groupBox1.Location = new System.Drawing.Point(36, 265);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1127, 389);
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
            this.dgvFunctionalFields.Location = new System.Drawing.Point(5, 20);
            this.dgvFunctionalFields.Margin = new System.Windows.Forms.Padding(5);
            this.dgvFunctionalFields.Name = "dgvFunctionalFields";
            this.dgvFunctionalFields.ReadOnly = true;
            this.dgvFunctionalFields.RowHeadersWidth = 51;
            this.dgvFunctionalFields.Size = new System.Drawing.Size(1117, 364);
            this.dgvFunctionalFields.TabIndex = 0;
            this.dgvFunctionalFields.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvFunctionalFields_CellMouseDoubleClick);
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
            // chkActiveOnly
            // 
            this.chkActiveOnly.AutoSize = true;
            this.chkActiveOnly.Location = new System.Drawing.Point(743, 226);
            this.chkActiveOnly.Margin = new System.Windows.Forms.Padding(4);
            this.chkActiveOnly.Name = "chkActiveOnly";
            this.chkActiveOnly.Size = new System.Drawing.Size(101, 21);
            this.chkActiveOnly.TabIndex = 19;
            this.chkActiveOnly.Text = "Active Only";
            this.chkActiveOnly.UseVisualStyleBackColor = true;
            // 
            // ucFunctionalFields
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucFunctionalFields";
            this.Size = new System.Drawing.Size(1200, 738);
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
