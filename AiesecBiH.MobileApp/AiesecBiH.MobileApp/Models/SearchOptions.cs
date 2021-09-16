using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AiesecBiH.MobileApp.Models
{
    public enum SearchOptions
    {
        [Display(Name ="Active only")]
        ActiveOnly,
        [Display(Name = "Team only")]
        AllTeam,
        [Display(Name = "All")]
        All,
    }
}
