using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AiesecBiH.Model.Insert;
using Task = System.Threading.Tasks.Task;

namespace AiesecBiH.WinUI.Reports
{
    public partial class ucReportsDetails : UserControl
    {
        private APIService _service = new APIService("Reports");
        private readonly int? _reportId;
        private byte[] _file;
        private string _extension;
        public ucReportsDetails(int? id=null)
        {
            if (id != null)
                _reportId = id;
            InitializeComponent();
        }
        private async Task LoadOReportDetails()
        {
            var result = await _service.GetById<Model.Response.Report>(_reportId);
            txtDescription.Text = result.Description;
            txtMandate.Text = result.Mandate;
            nudQuarter.Value = result.Quarter;
            txtName.Text = result.Name;

        }
        private void LoadReportCreate()
        {
            lblCreatedDate.Visible = false;
            dtpCreatedDate.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = true;
            btnSave.Text = "Create";
        }
        private void ucReportsDetails_Load(object sender, EventArgs e)
        {
            if (_reportId != null)
                LoadOReportDetails();
            else
                LoadReportCreate();
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog();
            var dialogResult = openFileDialog1.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            _extension = Path.GetExtension(openFileDialog1.FileName);
            if (_extension != ".pdf")
                MessageBox.Show("File must be PDF type!");
            else
            {
                lblFileName.Text = openFileDialog1.FileName; 
                _file = File.ReadAllBytes(openFileDialog1.FileName);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            var model = new Model.Insert.Report()
            {
                Name = txtName.Text,
                Description = txtDescription.Text,
                Mandate = txtMandate.Text,
                File =_file,
                Quarter = Convert.ToInt32(nudQuarter.Value)
            };
            await _service.Insert<Model.Response.Report>(model);
            MessageBox.Show("Successfully uploaded new report!");
            frmIndex.Instance.btnDashR_Click(null,null);
        }
    }
}
