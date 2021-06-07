using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AiesecBiH.Model.Extensions;
using Flurl.Http;

namespace AiesecBiH.WinUI
{
    public class NavigationService
    {
        public void ShowDetailsUC(UserControl detailsUC)
        {   
            frmIndex.Instance.PnlMain.Controls.Add(detailsUC);
            frmIndex.Instance.BackButton.Visible = true;
            detailsUC.BringToFront();
        }
    }
}
