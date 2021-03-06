
namespace AiesecBiH.WinUI.Offices
{
    partial class ucOffices
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
            this.cbxActiveOnly = new System.Windows.Forms.CheckBox();
            this.lblTitleUC = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnNewOffice = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOffices = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LocalCommittee = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Adress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Capacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstablishmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.cmbLocalCommittee = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxActiveOnly
            // 
            this.cbxActiveOnly.AutoSize = true;
            this.cbxActiveOnly.Location = new System.Drawing.Point(800, 215);
            this.cbxActiveOnly.Margin = new System.Windows.Forms.Padding(4);
            this.cbxActiveOnly.Name = "cbxActiveOnly";
            this.cbxActiveOnly.Size = new System.Drawing.Size(101, 21);
            this.cbxActiveOnly.TabIndex = 25;
            this.cbxActiveOnly.Text = "Active Only";
            this.cbxActiveOnly.UseVisualStyleBackColor = true;
            // 
            // lblTitleUC
            // 
            this.lblTitleUC.AutoSize = true;
            this.lblTitleUC.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.lblTitleUC.ForeColor = System.Drawing.SystemColors.Highlight;
            this.lblTitleUC.Location = new System.Drawing.Point(28, 96);
            this.lblTitleUC.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblTitleUC.Name = "lblTitleUC";
            this.lblTitleUC.Size = new System.Drawing.Size(109, 40);
            this.lblTitleUC.TabIndex = 23;
            this.lblTitleUC.Text = "Offices";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(32, 183);
            this.labelName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(112, 17);
            this.labelName.TabIndex = 22;
            this.labelName.Text = "Local Committee";
            // 
            // btnNewOffice
            // 
            this.btnNewOffice.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewOffice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewOffice.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewOffice.FlatAppearance.BorderSize = 0;
            this.btnNewOffice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewOffice.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewOffice.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnNewOffice.Location = new System.Drawing.Point(963, 96);
            this.btnNewOffice.Margin = new System.Windows.Forms.Padding(5);
            this.btnNewOffice.Name = "btnNewOffice";
            this.btnNewOffice.Size = new System.Drawing.Size(200, 49);
            this.btnNewOffice.TabIndex = 21;
            this.btnNewOffice.Text = "New";
            this.btnNewOffice.UseVisualStyleBackColor = false;
            this.btnNewOffice.Click += new System.EventHandler(this.btnNewOffice_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(963, 183);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(200, 49);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOffices);
            this.groupBox1.Location = new System.Drawing.Point(31, 256);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(5);
            this.groupBox1.Size = new System.Drawing.Size(1143, 388);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offices";
            // 
            // dgvOffices
            // 
            this.dgvOffices.AllowUserToAddRows = false;
            this.dgvOffices.AllowUserToDeleteRows = false;
            this.dgvOffices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffices.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.LocalCommittee,
            this.Adress,
            this.Capacity,
            this.EstablishmentDate,
            this.Active});
            this.dgvOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOffices.Location = new System.Drawing.Point(5, 20);
            this.dgvOffices.Margin = new System.Windows.Forms.Padding(5);
            this.dgvOffices.Name = "dgvOffices";
            this.dgvOffices.ReadOnly = true;
            this.dgvOffices.RowHeadersWidth = 51;
            this.dgvOffices.Size = new System.Drawing.Size(1133, 363);
            this.dgvOffices.TabIndex = 0;
            this.dgvOffices.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvOffices_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.MinimumWidth = 6;
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Id.Visible = false;
            // 
            // LocalCommittee
            // 
            this.LocalCommittee.DataPropertyName = "LocalCommitteeName";
            this.LocalCommittee.HeaderText = "Local Committee";
            this.LocalCommittee.MinimumWidth = 6;
            this.LocalCommittee.Name = "LocalCommittee";
            this.LocalCommittee.ReadOnly = true;
            // 
            // Adress
            // 
            this.Adress.DataPropertyName = "Address";
            this.Adress.HeaderText = "Address";
            this.Adress.MinimumWidth = 6;
            this.Adress.Name = "Adress";
            this.Adress.ReadOnly = true;
            // 
            // Capacity
            // 
            this.Capacity.DataPropertyName = "Capacity";
            this.Capacity.HeaderText = "Capacity";
            this.Capacity.MinimumWidth = 6;
            this.Capacity.Name = "Capacity";
            this.Capacity.ReadOnly = true;
            // 
            // EstablishmentDate
            // 
            this.EstablishmentDate.DataPropertyName = "EstablishmentDate";
            this.EstablishmentDate.HeaderText = "Establishment Date";
            this.EstablishmentDate.MinimumWidth = 6;
            this.EstablishmentDate.Name = "EstablishmentDate";
            this.EstablishmentDate.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // cmbLocalCommittee
            // 
            this.cmbLocalCommittee.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.cmbLocalCommittee.DisplayMember = "All";
            this.cmbLocalCommittee.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbLocalCommittee.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbLocalCommittee.FormattingEnabled = true;
            this.cmbLocalCommittee.Location = new System.Drawing.Point(31, 207);
            this.cmbLocalCommittee.Margin = new System.Windows.Forms.Padding(4);
            this.cmbLocalCommittee.Name = "cmbLocalCommittee";
            this.cmbLocalCommittee.Size = new System.Drawing.Size(348, 24);
            this.cmbLocalCommittee.TabIndex = 26;
            this.cmbLocalCommittee.ValueMember = "null";
            // 
            // ucOffices
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.cmbLocalCommittee);
            this.Controls.Add(this.cbxActiveOnly);
            this.Controls.Add(this.lblTitleUC);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnNewOffice);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ucOffices";
            this.Size = new System.Drawing.Size(1200, 738);
            this.Load += new System.EventHandler(this.ucOffices_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxActiveOnly;
        private System.Windows.Forms.Label lblTitleUC;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnNewOffice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOffices;
        private System.Windows.Forms.ComboBox cmbLocalCommittee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn LocalCommittee;
        private System.Windows.Forms.DataGridViewTextBoxColumn Adress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Capacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstablishmentDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
    }
}
