using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model
{
    public class Office
    {
        public string Address { get; set; }
        public int Capacity { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public int CityID { get; set; }
        public int? LocalCommitteeId { get; set; }
    }
}
