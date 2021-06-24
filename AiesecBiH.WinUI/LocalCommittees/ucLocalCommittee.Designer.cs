
namespace AiesecBiH.WinUI.LocalCommittees
{
    partial class ucLocalCommittee
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
            this.txtSearchCityName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.btnNewLC = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvLocalCommittees = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EstablishmentDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CreatedDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalCommittees)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxActiveOnly
            // 
            this.cbxActiveOnly.AutoSize = true;
            this.cbxActiveOnly.Location = new System.Drawing.Point(317, 182);
            this.cbxActiveOnly.Name = "cbxActiveOnly";
            this.cbxActiveOnly.Size = new System.Drawing.Size(80, 17);
            this.cbxActiveOnly.TabIndex = 18;
            this.cbxActiveOnly.Text = "Active Only";
            this.cbxActiveOnly.UseVisualStyleBackColor = true;
            // 
            // txtSearchCityName
            // 
            this.txtSearchCityName.Location = new System.Drawing.Point(29, 179);
            this.txtSearchCityName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchCityName.Name = "txtSearchCityName";
            this.txtSearchCityName.Size = new System.Drawing.Size(229, 20);
            this.txtSearchCityName.TabIndex = 17;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 17F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label4.Location = new System.Drawing.Point(21, 85);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(198, 31);
            this.label4.TabIndex = 16;
            this.label4.Text = "Local Committees";
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(24, 156);
            this.labelName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(55, 13);
            this.labelName.TabIndex = 15;
            this.labelName.Text = "City Name";
            // 
            // btnNewLC
            // 
            this.btnNewLC.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnNewLC.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNewLC.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnNewLC.FlatAppearance.BorderSize = 0;
            this.btnNewLC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewLC.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold);
            this.btnNewLC.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.btnNewLC.Location = new System.Drawing.Point(722, 85);
            this.btnNewLC.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewLC.Name = "btnNewLC";
            this.btnNewLC.Size = new System.Drawing.Size(150, 40);
            this.btnNewLC.TabIndex = 14;
            this.btnNewLC.Text = "New";
            this.btnNewLC.UseVisualStyleBackColor = false;
            this.btnNewLC.Click += new System.EventHandler(this.btnNewLC_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Calibri", 10F, System.Drawing.FontStyle.Bold);
            this.btnSearch.Location = new System.Drawing.Point(722, 156);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(150, 40);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvLocalCommittees);
            this.groupBox1.Location = new System.Drawing.Point(23, 215);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(857, 315);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Local Committees";
            // 
            // dgvLocalCommittees
            // 
            this.dgvLocalCommittees.AllowUserToAddRows = false;
            this.dgvLocalCommittees.AllowUserToDeleteRows = false;
            this.dgvLocalCommittees.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLocalCommittees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLocalCommittees.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.Name,
            this.EstablishmentDate,
            this.Active,
            this.CreatedDate});
            this.dgvLocalCommittees.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvLocalCommittees.Location = new System.Drawing.Point(4, 17);
            this.dgvLocalCommittees.Margin = new System.Windows.Forms.Padding(4);
            this.dgvLocalCommittees.Name = "dgvLocalCommittees";
            this.dgvLocalCommittees.ReadOnly = true;
            this.dgvLocalCommittees.Size = new System.Drawing.Size(849, 294);
            this.dgvLocalCommittees.TabIndex = 0;
            this.dgvLocalCommittees.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvLocalCommittees_CellMouseDoubleClick);
            // 
            // Id
            // 
            this.Id.DataPropertyName = "Id";
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Visible = false;
            // 
            // Name
            // 
            this.Name.DataPropertyName = "Name";
            this.Name.HeaderText = "Name";
            this.Name.Name = "Name";
            this.Name.ReadOnly = true;
            // 
            // EstablishmentDate
            // 
            this.EstablishmentDate.DataPropertyName = "EstablishmentDate";
            this.EstablishmentDate.HeaderText = "Establishment Date";
            this.EstablishmentDate.Name = "EstablishmentDate";
            this.EstablishmentDate.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Active.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // CreatedDate
            // 
            this.CreatedDate.DataPropertyName = "CreatedDate";
            this.CreatedDate.HeaderText = "Created Date";
            this.CreatedDate.Name = "CreatedDate";
            this.CreatedDate.ReadOnly = true;
            // 
            // ucLocalCommittee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.cbxActiveOnly);
            this.Controls.Add(this.txtSearchCityName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.btnNewLC);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.groupBox1);
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.ucLocalCommittee_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLocalCommittees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxActiveOnly;
        private System.Windows.Forms.TextBox txtSearchCityName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Button btnNewLC;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvLocalCommittees;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn EstablishmentDate;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Active;
        private System.Windows.Forms.DataGridViewTextBoxColumn CreatedDate;
    }
}
