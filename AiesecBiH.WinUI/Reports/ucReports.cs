using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using AiesecBiH.Model.Insert;
using Task = System.Threading.Tasks.Task;
using AiesecBiH.WinUI.GeneratedReports;

namespace AiesecBiH.WinUI.Reports
{
    public partial class ucReports : UserControl
    {
        private APIService _service = new APIService("Reports");
        private NavigationService _navigationService = new NavigationService();

        public ucReports()
        {
            InitializeComponent();
        }

        private void btnNewReport_Click(object sender, EventArgs e)
        {
            UserControl ucDetails = new ucReportsDetails();
            _navigationService.ShowDetailsUC(ucDetails);
        }

        private async void ucReports_Load(object sender, EventArgs e)
        {
            dgvReports.DataSource = await _service.Get<List<Model.Response.Report>>();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new Model.Search.Report()
            { 
                Mandate = txtSearchMandate.Text,
                Name = txtSearchName.Text
            };
            dgvReports.DataSource = await _service.Get<List<Model.Response.Report>>(search);
        }

        private async void dgvReports_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dgvReports.CurrentRow.Cells[Name = "Id"].Value.ToString();
            //Stream myStream;
            Model.Response.Report result = await _service.GetById<Model.Response.Report>(id);
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.FileName = result.Name;
            saveFileDialog1.Filter = "pdf (*.pdf)|*.pdf";
            saveFileDialog1.FilterIndex = 1;
            saveFileDialog1.RestoreDirectory = true;
            var dialogResult = saveFileDialog1.ShowDialog();
            if (dialogResult != DialogResult.OK) return;
            //File.WriteAllBytes(saveFileDialog1.FileName, result.File);
            var path = Path.GetFullPath(saveFileDialog1.FileName);
            File.WriteAllBytes(path+result.Extension, result.File);
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvReports.CurrentRow == null)
            {
                MessageBox.Show("Please select the report you want to delete.");
            }
            else
            {
                var id = dgvReports.CurrentRow.Cells[Name = "Id"].Value.ToString();
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this report?", "Caption", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    await _service.Delete<Model.Response.Report>(id);
                    MessageBox.Show("Succesfully deleted this Member:");
                    frmIndex.Instance.btnDashR_Click(null, null);
                }
            }
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            var frmReport = new frmChartReport();
            frmReport.ShowDialog();
        }
    }
}
