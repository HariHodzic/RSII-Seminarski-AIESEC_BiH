using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiesecBiH.WinUI.FunctionalFields
{
    public partial class ucFunctionalFields : UserControl
    {
        private APIService _service = new APIService("FunctionalFields");
        private NavigationService _navigationService = new NavigationService();
        public ucFunctionalFields()
        {
            InitializeComponent();
        }

        private void btnNewFunctField_Click(object sender, EventArgs e)
        {
            UserControl ucInsert = new ucFunctionalFieldsDetails();
            _navigationService.ShowDetailsUC(ucInsert);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            var search = new Model.Search.FunctionalField()
            {
                Name = txtSearchFFName.Text,
                Abbreviation = txtSearchFFAbr.Text,
                onlyActive = chkActiveOnly.Checked
            };
            dgvFunctionalFields.DataSource = await _service.Get<List<Model.Response.FunctionalField>>(search);

        }

        private void dgvFunctionalFields_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var id = dgvFunctionalFields.CurrentRow.Cells[Name = "Id"].Value.ToString();
            UserControl ucDetails = new ucFunctionalFieldsDetails(int.Parse(id));
            _navigationService.ShowDetailsUC(ucDetails);
            
        }

        private async void ucFunctionalFields_Load(object sender, EventArgs e)
        {
            dgvFunctionalFields.DataSource = await _service.Get<List<Model.Response.FunctionalField>>();
        }
    }
}
