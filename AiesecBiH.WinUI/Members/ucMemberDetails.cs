using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AiesecBiH.Model.Response;
using Flurl.Http;
using AiesecBiH.WinUI.Helpers;
using Task = System.Threading.Tasks.Task;

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
            }
        }

        private async void ucMemberDetails_Load(object sender, EventArgs e)
        {
            if (_member == null)
            {
                await LoadAddMemberForm();
            }
            else
            {
                await LoadMemberDetails();
            }
        }
        
        private async Task LoadMemberDetails()
        {
            txtUsername.Text = _member.Username;
            txtFirstName.Text = _member.FirstName;
            txtLastName.Text = _member.LastName;
            txtEmail.Text = _member.EmailAddress;
            txtAddress.Text = _member.Address;
            cbxActive.Checked = _member.Active;
            cmbGender.SelectedIndex = 0;
            await _localCommitteeService.LoadComboBox<LocalCommittee>(cmbLocalCommittee, "Name", _member.LocalCommitteeId);
            await _funcFieldService.LoadComboBox<FunctionalField>(cmbFunctionalField, "Name", _member.FunctionalFieldId);
            await _roleService.LoadComboBox<Role>(cmbRole, "Name", _member.RoleId);
            txtPhoneNumber.Text = _member.PhoneNumber;
            if (_member.BirthDate.Year < 1750)
            {
                dtpBirthDate.Value = dtpBirthDate.MinDate;
            }
            dtpCreatedDate.Value = _member.CreatedDate;
        }

        private async Task LoadAddMemberForm()
        {
            btnSave.Text = "Create";
            dtpCreatedDate.Visible = false;
            lblCreatedDate.Visible = false;
            lblUsername.Visible = false;
            txtUsername.Visible = false;
            cbxActive.Visible = false;
            await LoadFunctionalFieldsCMB();
            await LoadRolesCMB();
            await LoadLocalCommittesCMB();
        }
        private Model.Update.Member CreateUpdateModel()
        {
            var model = new Model.Update.Member()
            {
                Id = _member.Id,
                FirstName = txtFirstName.Text,
                LastName = txtLastName.Text,
                Address = txtAddress.Text,
                PhoneNumber = txtPhoneNumber.Text,
                BirthDate = dtpBirthDate.Value,
                LocalCommitteeId = Convert.ToInt32(cmbLocalCommittee.SelectedValue),
                FunctionalFieldId = Convert.ToInt32(cmbFunctionalField.SelectedValue),
                RoleId = Convert.ToInt32(cmbRole.SelectedValue),
                EmailAddress = txtEmail.Text,
                Gender = cmbGender.Text[0],
                Username = txtUsername.Text,
                Active=cbxActive.Checked
            };
            return model;
        }
        private Model.Insert.Member CreateInsertModel()
        {
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
                Gender = cmbGender.SelectedItem.ToString()[0],
            };
            return model;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (_member != null)
                {
                    Model.Update.Member model = CreateUpdateModel();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this record?", "Caption", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes && Validation.BaseValidation(model))
                    {
                        await _memberService.Update<Member>(model.Id, model);
                        MessageBox.Show("Successfully updated Member!");
                        frmIndex.Instance.btnMembers_Click(null, null);
                    }
                }
                else
                {
                    var model = CreateInsertModel();
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to creeate new record?", "Caption", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes && Validation.BaseValidation(model))
                    {
                        var result= await _memberService.Insert<Member>(model);
                        if (result != null)
                        {
                            MessageBox.Show("Succesfully created new Member!");
                            frmIndex.Instance.btnMembers_Click(null, null);
                        }
                    }
                }
            }
            catch (FlurlHttpException ex)
            {
                var a = await ex.GetResponseStringAsync();
                //var b = await ex.GetResponseJsonAsync<Error>();
                MessageBox.Show(a);
            }

        }

        private async Task LoadLocalCommittesCMB()
        {
            cmbLocalCommittee.DataSource = await _localCommitteeService.Get<List<Model.Response.LocalCommittee>>();
            cmbLocalCommittee.ValueMember = "Id";
            cmbLocalCommittee.DisplayMember = "Name";
        }
        private async Task LoadFunctionalFieldsCMB()
        {
            cmbFunctionalField.DataSource = await _funcFieldService.Get<List<Model.Response.FunctionalField>>();
            cmbFunctionalField.ValueMember = "Id";
            cmbFunctionalField.DisplayMember = "Name";
        }
        private async Task LoadRolesCMB()
        {
            cmbRole.DataSource = await _roleService.Get<List<Model.Response.Role>>();
            cmbRole.ValueMember = "Id";
            cmbRole.DisplayMember = "Name";
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?"+ _member.FirstName + _member.LastName + "/n" + _member.Username, "Caption", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                await _memberService.Delete<Member>(_member.Id);
                MessageBox.Show("Succesfully deleted this Member:");
                frmIndex.Instance.btnMembers_Click(null, null);
            }
        }
        
    }
}
     