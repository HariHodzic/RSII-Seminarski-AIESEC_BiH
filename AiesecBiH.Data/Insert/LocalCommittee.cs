using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Insert
{
    public class LocalCommittee
    {
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public string Name { get; set; }
        public DateTime EstablishmentDate { get; set; }

        //Implement computed property NumberOfMembers after finishing user profiles
        public int CityId { get; set; }
        
    }
}
