using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AiesecBiH.Model.Update;
using Task = System.Threading.Tasks.Task;

namespace AiesecBiH.WinUI.Offices
{
    public partial class ucOfficeDetails : UserControl
    {
        private APIService _service = new APIService("Offices");
        private readonly int? _officeId;

        public ucOfficeDetails()
        {
            InitializeComponent();
        }
        public ucOfficeDetails(int id)
        {
            InitializeComponent();
            _officeId = id;
        }
        private async Task LoadOfficeDetails()
        {
            //dtpCreatedDate.Visible = true;
            var result = await _service.GetById<Model.Response.Office>(_officeId);
            dtpCreatedDate.Value = result.CreatedDate;
            dtpEstDate.Value = result.EstablishmentDate;
            cbxActive.Checked = result.Active;
            nudCapacity.Value = result.Capacity;
            txtAddress.Text = result.Address;
            _service.LoadComboBox<Model.Response.LocalCommittee>(new APIService("LocalCommittees"), chkLocalCommittee, "Name", result.LocalCommitteeId);
            
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
            if (_officeId != null)
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
                var result = await _service.Delete<Model.Response.Office>(_officeId);
                MessageBox.Show("Successfully deleted Office!");
                frmIndex.Instance.btnDashO_Click(null, null);
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            if (_officeId != null)
            {
                Model.Update.Office request = new Office()
                {
                    //dtpCreatedDate.Value = result.CreatedDate;
                    //dtpEstDate.Value = result.EstablishmentDate;
                    //cbxActive.Checked = result.Active;
                    //nudCapacity.Value = result.Capacity;
                    //txtAddress.Text = result.Address;
                    EstablishmentDate = dtpEstDate.Value,
                    Active =cbxActive.Checked,
                    Capacity = Convert.ToInt32(nudCapacity.Value),
                    Address = txtAddress.Text,
                    LocalCommitteeId = Convert.ToInt32(chkLocalCommittee.SelectedValue)
                };
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this record?", "Caption", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = await _service.Update<Model.Response.Office>(_officeId, request);
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
                var result = await _service.Insert<Model.Response.Office>(request);
                MessageBox.Show("Successfully created new Office!");
                frmIndex.Instance.btnDashO_Click(null, null);

            }
        }
    }
}
