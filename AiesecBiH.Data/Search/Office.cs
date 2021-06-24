using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Search
{
    public class Office:BaseSearchModel
    {
        public string CityName { get; set; }
        public int? LocalCommitteeId { get; set; }
    }
}
