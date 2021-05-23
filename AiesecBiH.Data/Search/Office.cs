using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Search
{
    public class Office:BaseSearchModel
    {
        public string Address { get; set; }
        public int Capacity { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public string CityName { get; set; }
        public int? LocalCommitteeId { get; set; }
    }
}
