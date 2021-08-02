using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace AiesecBiH.MobileApp.ViewModels
{
    public class MemberDetailsViewModel:BaseViewModel
    {
        public Model.Response.MemberLL Member { get; set; }

    }
}
