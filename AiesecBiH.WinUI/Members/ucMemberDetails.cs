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
    public partial class ucMemberDetails : UserControl
    {
        private readonly MemberLL _member;
        private readonly APIService _memberService = new APIService("Members");
        private readonly APIService _funcFieldService = new APIService("FunctionalFields");
        private readonly APIService _roleService = new APIService("Roles");
        private readonly APIService _localCommitteeService = new APIService("LocalCommittees");
        public ucMemberDetails(MemberLL member)
        {
            InitializeComponent();
            if (member != null)
            {
                _member = member;
                LoadMemberDetails();
            }
        }

        private void ucMemberDetails_Load(object sender, EventArgs e)
        {
            if (_member == null)
            {
                dtpCreatedDate.Visible = false;
                lblCreatedDate.Visible = false;
                _localCommitteeService.LoadComboBox<LocalCommittee>(_localCommitteeService,cmbLocalCommittee,"Name");
                _funcFieldService.LoadComboBox<FunctionalField>(_funcFieldService,cmbFunctionalField,"Name");
                _roleService.LoadComboBox<Role>(_roleService,cmbRole,"Name");
            }
        }

        private void LoadMemberDetails()
        {
            txtFirstName.Text = _member.FirstName;
            txtLastName.Text = _member.LastName;
            txtEmail.Text = _member.EmailAddress;
            txtAddress.Text = _member.Address;
            cmbFunctionalField.Text = _member.FunctionalFieldName;
            cmbLocalCommittee.Text = _member.LocalCommitteeName;
            cbxActive.Checked = _member.Active;
            cmbGender.Text = _member.Gender.ToString();
            cmbRole.Text = _member.Role.Name;
            txtPhoneNumber.Text = _member.PhoneNumber;
            if (_member.BirthDate.Year < 1750)
            {
                dtpBirthDate.Value =dtpBirthDate.MinDate;
            }
            dtpCreatedDate.Value = _member.CreatedDate;
        }

        private void LoadNewMember()
        {
            btnSave.Text = "Create";
            
        }
        private Model.Update.Member LoadUpdateModel()
        {
            var model = new Model.Update.Member()
            {
                Id=_member.Id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                BirthDate = dtpBirthDate.Value,
                LocalCommitteeId = Convert.ToInt32(cmbLocalCommittee.SelectedValue),
                FunctionalFieldId = Convert.ToInt32(cmbFunctionalField.SelectedValue),
                RoleId = Convert.ToInt32(cmbRole.SelectedValue),
                EmailAddress = txtEmail.Text,
                Gender = cmbGender.Text[0]

            };
            return model;
        }
        private Model.Insert.Member LoadInsertModel()
        {
            Console.WriteLine(cmbFunctionalField.SelectedValue.ToString() + cmbLocalCommittee.SelectedValue.ToString() + cmbRole.SelectedValue.ToString());
            var model = new Model.Insert.Member()
            {
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                BirthDate = dtpBirthDate.Value,
                LocalCommitteeId = Convert.ToInt32(cmbLocalCommittee.SelectedValue),
                FunctionalFieldId = Convert.ToInt32(cmbFunctionalField.SelectedValue),
                RoleId = Convert.ToInt32(cmbRole.SelectedValue),
                EmailAddress = txtEmail.Text,
                Gender = cmbGender.Text[0]
            };
            return model;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_member != null)
            {
                Model.Update.Member model = LoadUpdateModel();
                await _memberService.Update<Member>(model.Id, model);
            }
            else
            {
                var model = LoadInsertModel();
                await _memberService.Insert<Member>(model);
            }
        }

        private void cmbRole_DropDown(object sender, EventArgs e)
        {
            _roleService.LoadComboBox<Role>(_roleService, cmbRole, "Name");

        }

        private void cmbFunctionalField_DropDown(object sender, EventArgs e)
        {
            _funcFieldService.LoadComboBox<FunctionalField>(_funcFieldService, cmbFunctionalField, "Name");
        }

        private void cmbLocalCommittee_DropDown(object sender, EventArgs e)
        {
            _localCommitteeService.LoadComboBox<LocalCommittee>(_localCommitteeService, cmbLocalCommittee, "Name");
        }
    }
}
     