using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AiesecBiH.Model.Update;
using Task = System.Threading.Tasks.Task;

namespace AiesecBiH.WinUI.LocalCommittees
{
    public partial class ucLocalCommitteeDetails : UserControl
    {
        private APIService _service = new APIService("LocalCommittees");
        private readonly int? _localCommitteeId;

        public ucLocalCommitteeDetails()
        {
            InitializeComponent();
        }

        public ucLocalCommitteeDetails(int id)
        {
            InitializeComponent();
            _localCommitteeId = id;
        }

        //private async void LoadComboBox<T>(APIService service, ComboBox cmb, string displayMember,int id)
        //{
        //    var source = await service.Get<List<T>>();
        //    cmb.DataSource = source;
        //    cmb.ValueMember = "Id";
        //    cmb.DisplayMember = displayMember;
        //    cmb.SelectedValue=id;
        //}


        private async Task LoadLocalCommitteeDetails()
        {
            var result = await _service.GetById<Model.Response.LocalCommittee>(_localCommitteeId);
            dtpCreatedDate.Text = result.CreatedDate.ToString();
            dtpCreatedDate.Enabled = false;
            dtpEstDate.Text = result.EstablishmentDate.ToString();
            cbxActive.Checked = result.Active;
            APIService cityService = new APIService("Cities");
            _service.LoadComboBox<Model.Response.City>(new APIService("Cities"), comboBoxCity, "Name",result.CityId);
            APIService officeService = new APIService("Offices");
            dgvOffices.DataSource = await officeService.Get<List<Model.Response.Office>>(new Model.Search.Office()
                {LocalCommitteeId = _localCommitteeId});
        }

        private void LoadLocalCommitteeCreate()
        {
            _service.LoadComboBox<Model.Response.City>(new APIService("Cities"), comboBoxCity, "Name");
            cbxActive.Visible = false;
            lblCreatedDate.Visible = false;
            cbxActive.Checked = true;
            dtpCreatedDate.Visible = false;
            dgvOffices.Visible = false;
            dgvMembers.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = true;
            btnSave.Text = "Create";
        }
        private async void ucLocalCommitteeDetails_Load(object sender, EventArgs e)
        {
            if (_localCommitteeId != null)
            {
                await LoadLocalCommitteeDetails();
            }
            else
            {
                LoadLocalCommitteeCreate();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_localCommitteeId != null)
            {
                Model.Update.LocalCommittee request = new LocalCommittee()
                {
                    EstablishmentDate = dtpEstDate.Value,
                    CityId = Convert.ToInt32(comboBoxCity.SelectedValue),
                    Active = cbxActive.Checked
                };
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this record?", "Caption", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = await _service.Update<Model.Response.LocalCommittee>(_localCommitteeId, request);
                    MessageBox.Show("Successfully updated Local Committee!");
                    frmIndex.Instance.btnDashLC_Click(null, null);
                }
            }
            else
            {
                Model.Insert.LocalCommittee request = new Model.Insert.LocalCommittee()
                {
                    EstablishmentDate = dtpCreatedDate.Value,
                    CityId = Convert.ToInt32(comboBoxCity.SelectedValue),
                };
                var result = await _service.Insert<Model.Response.LocalCommittee>(request);
                frmIndex.Instance.btnDashLC_Click(null, null);
                MessageBox.Show("Successfully created new Local Committee!");

            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this?", "Caption", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var result = await _service.Delete<Model.Response.LocalCommittee>(_localCommitteeId);
                MessageBox.Show("Successfully deleted Local Committee!");
                frmIndex.Instance.btnDashLC_Click(null, null);
            }
        }
    }
}
