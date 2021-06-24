using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AiesecBiH.Model.Response;
using AiesecBiH.WinUI.LocalCommittees;
using Task = System.Threading.Tasks.Task;

namespace AiesecBiH.WinUI.Offices
{
    public partial class ucOffices : UserControl
    {
        private APIService _LocalCommitteeService = new APIService("LocalCommittees");
        private APIService _service = new APIService("Offices");
        private NavigationService _navigationService = new NavigationService();

        public ucOffices()
        {
            InitializeComponent();
            dgvOffices.AutoGenerateColumns = false;
        }

        private void dgvOffices_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //var id = dgvOffices.CurrentRow.Cells[Name = "Id"].Value.ToString();
            //UserControl ucDetails = new ucOfficeDetails(int.Parse(id)) { Dock = DockStyle.Fill };
            //_navigationService.ShowDetailsUC(ucDetails);
            var item = dgvOffices.CurrentRow.DataBoundItem;
            UserControl ucDetails = new ucOfficeDetails(item as Office);
            _navigationService.ShowDetailsUC(ucDetails);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var search = new Model.Search.Office()
                {
                    LocalCommitteeId = Convert.ToInt32(cmbLocalCommittee.SelectedValue),
                    onlyActive = cbxActiveOnly.Checked
                };
                dgvOffices.DataSource = await _service.Get<List<Model.Response.Office>>(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"{ex.Message} {ex.Source}");
            }
        }

        private async void ucOffices_Load(object sender, EventArgs e)
        {
            dgvOffices.DataSource = await _service.Get<List<Model.Response.Office>>();
            LoadLocalCommittees();

        }
        private async Task LoadLocalCommittees()
        {
            var localCommittees = await _LocalCommitteeService.Get<List<LocalCommittee>>();
            localCommittees.Insert(0, new LocalCommittee());
            cmbLocalCommittee.DataSource = localCommittees;
            cmbLocalCommittee.ValueMember = "Id";
            cmbLocalCommittee.DisplayMember = "Name";
        }
        private void btnNewOffice_Click(object sender, EventArgs e)
        {
            UserControl ucDetails = new ucOfficeDetails() { Dock = DockStyle.Fill };
            _navigationService.ShowDetailsUC(ucDetails);
        }
    }
}
