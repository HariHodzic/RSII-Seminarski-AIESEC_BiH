using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace AiesecBiH.WinUI.GeneratedReports
{
    public partial class frmChartReport : Form
    {
        private readonly APIService _MemberService = new APIService("Members");
        public frmChartReport()
        {
            InitializeComponent();
        }

        private async void frmChartReport_Load(object sender, EventArgs e)
        {
            var _allMembers = await _MemberService.Get<List<Model.Response.MemberLL>>();
            int countAllMembers = _allMembers.Count();

            ReportParameterCollection rpc = new ReportParameterCollection();
            this.reportViewer1.LocalReport.SetParameters(new ReportParameter("MembersCount", countAllMembers.ToString()));


            ReportDataSource rds = new ReportDataSource("MembersDataSet", _allMembers);
            this.reportViewer1.LocalReport.DataSources.Add(rds);

            this.reportViewer1.RefreshReport();
        }


    }
}
