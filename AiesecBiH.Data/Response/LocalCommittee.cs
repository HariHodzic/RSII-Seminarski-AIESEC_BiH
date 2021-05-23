using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Response
{
    public class LocalCommittee
    {
        public string Name { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public int CityId { get; set; }
        public City City { get; set; } 
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }

    }
}
