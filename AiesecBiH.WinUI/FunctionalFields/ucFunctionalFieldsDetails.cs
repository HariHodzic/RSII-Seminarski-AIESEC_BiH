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

namespace AiesecBiH.WinUI.FunctionalFields
{
    public partial class ucFunctionalFieldsDetails : UserControl
    {
        private APIService _service = new APIService("FunctionalFields");
        private readonly int? _functionalFieldId;
        public ucFunctionalFieldsDetails()
        {
            InitializeComponent();
        }
        public ucFunctionalFieldsDetails(int id)
        {
            InitializeComponent();
            _functionalFieldId = id;
        }
        private async Task LoadFunctionalFieldDetail()
        {
            var result = await _service.GetById<Model.Response.FunctionalField>(_functionalFieldId);
            txtName.Text = result.Name;
            txtAbbreviation.Text = result.Abbreviation;
            txtDescription.Text = result.Description;
            chkActive.Checked = result.Active;
            btnSave.Text = "Update";
        }
        private void LoadFunctionalFieldCreate()
        {
            btnSave.Text = "Create";
            chkActive.Visible = false;
            btnDelete.Visible = false;
        }
        private async void ucFunctionalFieldsDetails_Load(object sender, EventArgs e)
        {
            if (_functionalFieldId != null)
            {
                await LoadFunctionalFieldDetail();
            }
            else
            {
                LoadFunctionalFieldCreate();
            }
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            //UPDATE
            if (_functionalFieldId != null)
            {
                Model.Update.FunctionalField request = new FunctionalField()
                {
                    Abbreviation = txtAbbreviation.Text,
                    Description = txtDescription.Text,
                    Name = txtName.Text,
                    Active = chkActive.Checked
                };
                var result = await _service.Update<Model.Response.FunctionalField>(_functionalFieldId,request);
                frmIndex.Instance.btnDashFF_Click(null,null);
                MessageBox.Show("Successfully updated Functional Field!");
            }
            //INSERT
            else
            {
                try
                {

                    Model.Insert.FunctionalField request = new Model.Insert.FunctionalField()
                    {
                        Abbreviation = txtAbbreviation.Text,
                        Description = txtDescription.Text,
                        Name = txtName.Text
                    };
                    var result = await _service.Insert<Model.Response.FunctionalField>(request);
                    frmIndex.Instance.btnDashFF_Click(null, null);
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult=MessageBox.Show("Are you sure you want to delete this?","Caption",MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                var result = await _service.Delete<Model.Response.FunctionalField>(_functionalFieldId);
                frmIndex.Instance.btnDashFF_Click(null, null);
                MessageBox.Show("Successfully deleted Functional Field!");
            }
        }
    }
}
