using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AiesecBiH.WinUI.FunctionalFields;
using AiesecBiH.WinUI.LocalCommittees;
using AiesecBiH.WinUI.Members;
using AiesecBiH.WinUI.Offices;
using AiesecBiH.WinUI.Reports;

namespace AiesecBiH.WinUI
{
    public partial class frmIndex : Form
    {
        private int childFormNumber = 0;
        //private string _member;
        private static frmIndex _obj;
        private UserControl activeUserControl = null;
        public static frmIndex Instance
        {
            get
            {
                if (_obj == null)
                    _obj = new frmIndex();
                return _obj;
            }
        }

        public Panel PnlMain
        {
            get { return panelMain;}
            set { panelMain = value; }
        }
        public Button BackButton
        {
            get { return btnBack; }
            set { btnBack = value; }
        }
        //public frmIndex(string member )
        //{
        //    _member = member;
        //    InitializeComponent();
        //    btnMembers_Click(null,null);
        //    lblHeaderUsername.Text = _member;
        //}
        public frmIndex()
        {
            InitializeComponent();
            btnMembers_Click(null, null);
        }
        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        public void btnDashFF_Click(object sender, EventArgs e)
        {
            
            DisposePanel(panelMain);
            activeUserControl = new ucFunctionalFields(){};
            this.panelMain.Controls.Add(activeUserControl);
        }
        public void btnDashLC_Click(object sender, EventArgs e)
        {
            DisposePanel(panelMain);
            activeUserControl = new ucLocalCommittee() {Dock = DockStyle.Fill};
            this.panelMain.Controls.Add(activeUserControl);
        }

        private void frmIndex_Load(object sender, EventArgs e)
        {
            btnBack.Visible = false;
            _obj = this;
            
        }
        private void DisposePanel(Panel panel)
        {
            if (activeUserControl != null)
            {
                activeUserControl.Dispose();
            }
            btnBack.Visible = false;
            foreach (Control c in panel.Controls)
            {
                c.Dispose();
            }
        }
        private void btnSidebar_Click(object sender, EventArgs e)
        {
            if (panelSidebar.Width == 200)
            {
                MinimizeSidebar(50, 49);
            }
            else
            {
                MaximizeSidebar(200, 199);
            }
        }

        private void MinimizeSidebar(int sidebarMinWidth, int btnMinWidth)
        {
            btnSidebar.Text = ">";
            labelTitle.Visible = false;
            panelSidebar.Width = sidebarMinWidth;
            btnSidebarFF.Width = btnMinWidth;
            btnSidebarLC.Width = btnMinWidth;
            btnDashO.Width = btnMinWidth;
            btnDashR.Width = btnMinWidth;
            btnLogOut.Width = btnMinWidth;
            btnMembers.Width = btnMinWidth;
            btnSidebarFF.Text = "FF";
            btnSidebarLC.Text = "LC";
            btnDashO.Text = "O";
            btnDashR.Text = "R";
            btnLogOut.Text = "L";
            btnMembers.Text = "M";
            panelMain.Width += 180;
        }
        private void MaximizeSidebar(int sidebarMaxWidth, int btnMaxWidth)
        {
            btnSidebar.Text = "<";
            labelTitle.Visible = true;
            panelSidebar.Width = sidebarMaxWidth;
            btnSidebarFF.Width = btnMaxWidth;
            btnSidebarLC.Width = btnMaxWidth;
            btnDashO.Width = btnMaxWidth;
            btnDashR.Width = btnMaxWidth;
            btnLogOut.Width = btnMaxWidth;
            btnMembers.Width = btnMaxWidth;
            btnSidebarFF.Text = "Functional Fields";
            btnSidebarLC.Text = "Local Committees";
            btnDashO.Text = "Offices";
            btnDashR.Text = "Reports";
            btnLogOut.Text = "Log Out";
            btnMembers.Text = "Members";
            panelMain.Width -= 180;

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            foreach (Control c in panelMain.Controls)
            {
                c.Dispose();
            }

            btnBack.Visible = false;
        }

        public void btnDashO_Click(object sender, EventArgs e)
        {
            DisposePanel(panelMain);
            activeUserControl = new ucOffices() { Dock = DockStyle.Fill };
            this.panelMain.Controls.Add(activeUserControl);
        }

        public void btnDashR_Click(object sender, EventArgs e)
        {
            DisposePanel(panelMain);
            activeUserControl = new ucReports() { Dock = DockStyle.Fill };
            this.panelMain.Controls.Add(activeUserControl);
        }

        public void btnMembers_Click(object sender, EventArgs e)
        {
            DisposePanel(panelMain);
            activeUserControl = new ucMembers() {};
            this.panelMain.Controls.Add(activeUserControl);
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
