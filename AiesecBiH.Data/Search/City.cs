using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Search
{
    public class City:BaseSearchModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool? HasLocalCommittee { get; set; }
    }
}
