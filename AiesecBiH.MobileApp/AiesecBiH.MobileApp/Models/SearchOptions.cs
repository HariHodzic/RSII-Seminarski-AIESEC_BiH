using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AiesecBiH.MobileApp.Models
{
    public enum SearchOptions
    {
        [Display(Name ="Team Active")]
        TeamActive,
        [Display(Name = "All from team")]
        AllTeam,
        [Display(Name = "All")]
        All,
        [Display(Name = "All active")]
        AllActive,
    }
}
