
namespace AiesecBiH.WinUI.LocalCommittees
{
    partial class ucLocalCommitteeDetails
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
            this.cbxActive = new System.Windows.Forms.CheckBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.lblCreatedDate = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvOffices = new System.Windows.Forms.DataGridView();
            this.Members = new System.Windows.Forms.GroupBox();
            this.dgvMembers = new System.Windows.Forms.DataGridView();
            this.comboBoxCity = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpCreatedDate = new System.Windows.Forms.DateTimePicker();
            this.dtpEstDate = new System.Windows.Forms.DateTimePicker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).BeginInit();
            this.Members.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).BeginInit();
            this.SuspendLayout();
            // 
            // cbxActive
            // 
            this.cbxActive.AutoSize = true;
            this.cbxActive.Checked = true;
            this.cbxActive.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbxActive.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxActive.Location = new System.Drawing.Point(33, 313);
            this.cbxActive.Name = "cbxActive";
            this.cbxActive.Size = new System.Drawing.Size(64, 21);
            this.cbxActive.TabIndex = 19;
            this.cbxActive.Text = "Active";
            this.cbxActive.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(32, 352);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 33);
            this.btnDelete.TabIndex = 18;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(309, 352);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 33);
            this.btnSave.TabIndex = 17;
            this.btnSave.Text = "Update";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.SystemColors.Highlight;
            this.labelTitle.Location = new System.Drawing.Point(28, 65);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(235, 37);
            this.labelTitle.TabIndex = 16;
            this.labelTitle.Text = "Local Committee";
            // 
            // lblCreatedDate
            // 
            this.lblCreatedDate.AutoSize = true;
            this.lblCreatedDate.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCreatedDate.Location = new System.Drawing.Point(31, 209);
            this.lblCreatedDate.Name = "lblCreatedDate";
            this.lblCreatedDate.Size = new System.Drawing.Size(87, 17);
            this.lblCreatedDate.TabIndex = 15;
            this.lblCreatedDate.Text = "Created Date";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(118, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = " ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(31, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(125, 17);
            this.label4.TabIndex = 20;
            this.label4.Text = "Establishment Date";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dgvOffices);
            this.groupBox1.Location = new System.Drawing.Point(513, 76);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 200);
            this.groupBox1.TabIndex = 22;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Offices";
            // 
            // dgvOffices
            // 
            this.dgvOffices.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvOffices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOffices.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvOffices.Location = new System.Drawing.Point(3, 16);
            this.dgvOffices.Name = "dgvOffices";
            this.dgvOffices.Size = new System.Drawing.Size(344, 181);
            this.dgvOffices.TabIndex = 0;
            // 
            // Members
            // 
            this.Members.Controls.Add(this.dgvMembers);
            this.Members.Location = new System.Drawing.Point(513, 301);
            this.Members.Name = "Members";
            this.Members.Size = new System.Drawing.Size(350, 200);
            this.Members.TabIndex = 23;
            this.Members.TabStop = false;
            this.Members.Text = "Members";
            // 
            // dgvMembers
            // 
            this.dgvMembers.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvMembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMembers.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvMembers.Location = new System.Drawing.Point(3, 16);
            this.dgvMembers.Name = "dgvMembers";
            this.dgvMembers.Size = new System.Drawing.Size(344, 181);
            this.dgvMembers.TabIndex = 1;
            // 
            // comboBoxCity
            // 
            this.comboBoxCity.FormattingEnabled = true;
            this.comboBoxCity.Location = new System.Drawing.Point(33, 135);
            this.comboBoxCity.Name = "comboBoxCity";
            this.comboBoxCity.Size = new System.Drawing.Size(374, 21);
            this.comboBoxCity.TabIndex = 24;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(32, 113);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 17);
            this.label5.TabIndex = 25;
            this.label5.Text = "City";
            // 
            // dtpCreatedDate
            // 
            this.dtpCreatedDate.Enabled = false;
            this.dtpCreatedDate.Location = new System.Drawing.Point(33, 229);
            this.dtpCreatedDate.Name = "dtpCreatedDate";
            this.dtpCreatedDate.Size = new System.Drawing.Size(374, 20);
            this.dtpCreatedDate.TabIndex = 26;
            // 
            // dtpEstDate
            // 
            this.dtpEstDate.Location = new System.Drawing.Point(33, 186);
            this.dtpEstDate.Name = "dtpEstDate";
            this.dtpEstDate.Size = new System.Drawing.Size(374, 20);
            this.dtpEstDate.TabIndex = 27;
            // 
            // ucLocalCommitteeDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.Controls.Add(this.dtpEstDate);
            this.Controls.Add(this.dtpCreatedDate);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxCity);
            this.Controls.Add(this.Members);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbxActive);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.lblCreatedDate);
            this.Controls.Add(this.label2);
            this.Name = "ucLocalCommitteeDetails";
            this.Size = new System.Drawing.Size(900, 600);
            this.Load += new System.EventHandler(this.ucLocalCommitteeDetails_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvOffices)).EndInit();
            this.Members.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMembers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbxActive;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label lblCreatedDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvOffices;
        private System.Windows.Forms.GroupBox Members;
        private System.Windows.Forms.DataGridView dgvMembers;
        private System.Windows.Forms.ComboBox comboBoxCity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpCreatedDate;
        private System.Windows.Forms.DateTimePicker dtpEstDate;
    }
}
