using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AiesecBiH.WinUI
{
    public partial class frmLogin : Form
    {
        private APIService _service = new APIService("Members");
        private frmIndex frmIndex;

        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                APIService.Username = txtUsername.Text;
                APIService.Password = txtPassword.Text;
                APIService x = new APIService("Offices");
                var result = await _service.Get<List<Model.Response.Member>>(new Model.Search.Member { Username = txtUsername.Text });
                if(result[0].RoleId!=1)
                    MessageBox.Show("You are not authorized to access this application!");
                else
                    ShowForm();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Incorrect username or password! "+ ex.InnerException);
            }
        }

        private void ShowForm()
        {
            if (frmIndex == null)
            {
                frmIndex = new frmIndex();
                frmIndex.Show();
            }
            else if (!frmIndex.Visible)
            {
                frmIndex.Dispose();
                frmIndex = new frmIndex();
                frmIndex.Show();
            }
            else
            {
                frmIndex.BringToFront();
            }
        }
    }
}
