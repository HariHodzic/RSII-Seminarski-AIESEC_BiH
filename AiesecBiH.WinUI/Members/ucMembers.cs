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

namespace AiesecBiH.WinUI.Members
{
    public partial class ucMembers : UserControl
    {
        private readonly APIService _memberService = new APIService("Members");
        private readonly APIService _functionalFieldService = new APIService("FunctionalFields");
        private readonly APIService _localCommitteeService = new APIService("LocalCommittees");
        private readonly NavigationService _navigationService = new NavigationService();
        public ucMembers()
        {
            InitializeComponent();
            dgvMembers.AutoGenerateColumns=false;
            LoadFFields();
            LoadLocalCommittees();
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                var search = new Model.Search.Member()
                {
                    FirstName = txtFirstName.Text,
                    LastName = txtlastName.Text,
                    FunctionalFieldId = Convert.ToInt32(cmbFunctionalField.SelectedValue),
                    LocalCommitteeId = Convert.ToInt32(cmbLocalCommittee.SelectedValue),
                    onlyActive = chkActiveOnly.Checked
                };
                dgvMembers.DataSource = await _memberService.Get<List<Model.Response.MemberLL>>(search);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private async void ucMembers_Load(object sender, EventArgs e)
        {
            dgvMembers.DataSource = await _memberService.Get<List<Model.Response.MemberLL>>();
        }

        private async void LoadFFields()
        {
            var items = await _functionalFieldService.Get<List<FunctionalField>>(null);
            items.Insert(0, new FunctionalField());
            cmbFunctionalField.DataSource = items;
            cmbFunctionalField.ValueMember = "Id";
            cmbFunctionalField.DisplayMember = "Abbreviation";
        }
        private async void LoadLocalCommittees()
        {
            var items = await _localCommitteeService.Get<List<LocalCommittee>>(null);
            items.Insert(0, new LocalCommittee());
            cmbLocalCommittee.DataSource = items;
            cmbLocalCommittee.ValueMember = "Id";
            cmbLocalCommittee.DisplayMember = "Name";
        }

        private void dgvMembers_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            var item = dgvMembers.CurrentRow.DataBoundItem;
            UserControl ucDetails = new ucMemberDetails(item as MemberLL);
            _navigationService.ShowDetailsUC(ucDetails);
        }

        private void btnNewMember_Click(object sender, EventArgs e)
        {
            UserControl ucDetails = new ucMemberDetails(null);
            _navigationService.ShowDetailsUC(ucDetails);
        }
    }
}
