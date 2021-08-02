using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Update
{
    public class LocalCommittee
    {
        public string Name { get; set; }
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EstablishmentDate { get; set; }
        //public int CityId { get; set; }
        public bool Active { get; set; }

    }
}
