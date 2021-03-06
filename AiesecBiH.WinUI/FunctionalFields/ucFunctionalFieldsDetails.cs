using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AiesecBiH.Model.Response;
using AiesecBiH.WinUI.Helpers;
using Task = System.Threading.Tasks.Task;

namespace AiesecBiH.WinUI.FunctionalFields
{
    public partial class ucFunctionalFieldsDetails : UserControl
    {
        private APIService _service = new APIService("FunctionalFields");
        private readonly FunctionalField _functionalField;
        public ucFunctionalFieldsDetails(FunctionalField functionalField=null)
        {
            InitializeComponent();
            _functionalField =functionalField;
        }
        private void LoadFunctionalFieldDetail()
        {
            txtName.Text = _functionalField.Name;
            txtAbbreviation.Text = _functionalField.Abbreviation;
            txtDescription.Text = _functionalField.Description;
            chkActive.Checked = _functionalField.Active;
            btnSave.Text = "Update";
        }
        private void LoadFunctionalFieldCreate()
        {
            btnSave.Text = "Create";
            chkActive.Visible = false;
            btnDelete.Visible = false;
        }
        private void ucFunctionalFieldsDetails_Load(object sender, EventArgs e)
        {
            if (_functionalField != null)
            {
                LoadFunctionalFieldDetail();
            }
            else
            {
                LoadFunctionalFieldCreate();
            }
        }
            
        private async void btnSave_Click(object sender, EventArgs e)
        {
            //UPDATE
            if (_functionalField != null)
            {
                Model.Update.FunctionalField request = new Model.Update.FunctionalField()
                {
                    Abbreviation = txtAbbreviation.Text,
                    Description = txtDescription.Text,
                    Name = txtName.Text,
                    Active = chkActive.Checked
                };
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to update this record?", "Caption", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes && Validation.BaseValidation(request))
                {
                    var result = await _service.Update<FunctionalField>(_functionalField.Id, request);
                    frmIndex.Instance.btnDashFF_Click(null, null);
                    MessageBox.Show("Successfully updated Functional Field!");
                }
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
                    DialogResult dialogResult = MessageBox.Show("Are you sure you want to create new Functiona Field?", "Caption", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes && Validation.BaseValidation(request))
                    {
                        var result = await _service.Insert<FunctionalField>(request);
                        if (result != null)
                        {
                            frmIndex.Instance.btnDashFF_Click(null, null);
                            MessageBox.Show("Successfully created new Functional Field!");
                        }
                    }
                }
                catch (Exception exception)
                {
                    MessageBox.Show(exception.Message);
                }
                
            }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult=MessageBox.Show("Are you sure you want to delete this?","Caption",MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    var result = await _service.Delete<FunctionalField>(_functionalField.Id);
                    frmIndex.Instance.btnDashFF_Click(null, null);
                    MessageBox.Show("Successfully deleted Functional Field!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + " " + ex.InnerException );
            }
        }
    }
}
