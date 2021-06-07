using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiesecBiH.WinUI.Offices
{
    public partial class ucOffices : UserControl
    {
        private APIService _service = new APIService("Offices");
        private NavigationService _navigationService = new NavigationService();

        public ucOffices()
        {
            InitializeComponent();
        }

        private void dgvOffices_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dgvOffices.CurrentRow.Cells[Name = "Id"].Value.ToString();
            UserControl ucDetails = new ucOfficeDetails(int.Parse(id)) { Dock = DockStyle.Fill };
            _navigationService.ShowDetailsUC(ucDetails);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new Model.Search.Office()
            {
                LocalCommitteeId = Convert.ToInt32(cmbLocalCommittee.SelectedValue),
                onlyActive = cbxActiveOnly.Checked
            };
            dgvOffices.DataSource = await _service.Get<List<Model.Response.Office>>(search);
        }

        private async void ucOffices_Load(object sender, EventArgs e)
        {
            dgvOffices.DataSource = await _service.Get<List<Model.Response.Office>>();
            _service.LoadComboBox<Model.Response.LocalCommittee>(new APIService("LocalCommittees"), cmbLocalCommittee,"Name");

        }

        private void btnNewOffice_Click(object sender, EventArgs e)
        {
            UserControl ucDetails = new ucOfficeDetails() { Dock = DockStyle.Fill };
            _navigationService.ShowDetailsUC(ucDetails);
        }
    }
}
