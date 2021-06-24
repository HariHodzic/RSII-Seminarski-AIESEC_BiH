using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AiesecBiH.Model.Response;
using AiesecBiH.WinUI.FunctionalFields;

namespace AiesecBiH.WinUI.LocalCommittees
{
    public partial class ucLocalCommittee : UserControl
    {
        private APIService _service = new APIService("LocalCommittees");
        private NavigationService _navigationService = new NavigationService();

        public ucLocalCommittee()
        {
            InitializeComponent();
            dgvLocalCommittees.AutoGenerateColumns = false;
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new Model.Search.LocalCommittee()
            {
                CityName = txtSearchCityName.Text,
                onlyActive = cbxActiveOnly.Checked
            };
            dgvLocalCommittees.DataSource = await _service.Get<List<Model.Response.LocalCommittee>>(search);
        }

        private void dgvLocalCommittees_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //var id = dgvLocalCommittees.CurrentRow.Cells[Name = "Id"].Value.ToString();
            LocalCommittee item = (LocalCommittee)dgvLocalCommittees.CurrentRow.DataBoundItem;
            UserControl ucDetails = new ucLocalCommitteeDetails(item.Id){Dock = DockStyle.Fill};
            _navigationService.ShowDetailsUC(ucDetails);
        }

        private async void ucLocalCommittee_Load(object sender, EventArgs e)
        {
            dgvLocalCommittees.DataSource = await _service.Get<List<Model.Response.LocalCommittee>>();
        }

        private void btnNewLC_Click(object sender, EventArgs e)
        {
            UserControl ucDetails = new ucLocalCommitteeDetails() { Dock = DockStyle.Fill };
            _navigationService.ShowDetailsUC(ucDetails);
        }

        //private async void ucLocalCommittee_Load(object sender, EventArgs e)
        //{
        ////    dgvLocalCommittees.DataSource = await _service.Get<List<Model.Response.LocalCommittee>>();
        //}

    }
}
