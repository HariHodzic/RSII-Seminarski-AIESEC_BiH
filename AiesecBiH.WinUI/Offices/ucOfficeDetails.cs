using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AiesecBiH.Model.Response;
using Task = System.Threading.Tasks.Task;

namespace AiesecBiH.WinUI.Offices
{
    public partial class ucOfficeDetails : UserControl
    {
        private APIService _service = new APIService("Offices");
        private APIService _LocalCommitteeService = new APIService("LocalCommittees");
        private readonly Office _office;
        
        public ucOfficeDetails(Office office=null)
        {
            InitializeComponent();
            _office = office;
        }
        private async Task LoadOfficeDetails()
        {
            //dtpCreatedDate.Visible = true;
            dtpCreatedDate.Value = _office.CreatedDate;
            dtpCreatedDate.Enabled = false;
            dtpEstDate.Value = _office.EstablishmentDate;
            cbxActive.Checked = _office.Active;
            nudCapacity.Value = _office.Capacity;
            txtAddress.Text = _office.Address;
            _service.LoadComboBox<Model.Response.LocalCommittee>(new APIService("LocalCommittees"), chkLocalCommittee, "Name", _office.LocalCommitteeId);
            
        }
        private void LoadOfficeCreate()
        {
            _service.LoadComboBox<Model.Response.LocalCommittee>(new APIService("LocalCommittees"), chkLocalCommittee, "Name");
            cbxActive.Visible = false;
            lblCreatedDate.Visible = false;
            cbxActive.Checked = true;
            dtpCreatedDate.Visible = false;
            btnDelete.Visible = false;
            btnSave.Visible = true;
            btnSave.Text = "Create";
        }

        private async void ucOfficeDetails_Load(object sender, EventArgs e)
        {
            if (_office != null)
            {
                await LoadOfficeDetails();
            }
            else
            {
                LoadOfficeCreate();
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete this record?", "Caption", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var result = await _service.Delete<Model.Response.Office>(_office.Id);
                MessageBox.Show("Successfully deleted Office!");
                frmIndex.Instance.btnDashO_Click(null, null);
            }
        }
        

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_office != null)
            {
                Model.Update.Office request = new Model.Update.Office()
                {
                    EstablishmentDate = dtpEstDate.Value,
                    Active =cbxActive.Checked,
                    Capacity = Convert.ToInt32(nudCapacity.Value),
                    Address = txtAddress.Text,
                    LocalCommitteeId = Convert.ToInt32(chkLocalCommittee.SelectedValue)
                };
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this record?", "Caption", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = await _service.Update<Model.Response.Office>(_office.Id, request);
                    MessageBox.Show("Successfully updated Office!");
                    frmIndex.Instance.btnDashO_Click(null, null);
                }
            }
            else
            {
                Model.Insert.Office request = new Model.Insert.Office()
                {
                    EstablishmentDate = dtpEstDate.Value,
                    Capacity = Convert.ToInt32(nudCapacity.Value),
                    Address = txtAddress.Text,
                    LocalCommitteeId = Convert.ToInt32(chkLocalCommittee.SelectedValue)
                };
                var result = await _service.Insert<Office>(request);
                MessageBox.Show("Successfully created new Office!");
                frmIndex.Instance.btnDashO_Click(null, null);

            }
        }
    }
}
