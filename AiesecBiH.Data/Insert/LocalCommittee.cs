using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Insert
{
    public class LocalCommittee
    {
        [StringLength(35, MinimumLength =3)]
        public string Name { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EstablishmentDate { get; set; }
        //[Required]
        //public int CityId { get; set; }
        
    }
}
