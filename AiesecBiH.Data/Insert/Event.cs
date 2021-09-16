using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Insert
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool AllMembers { get; set; }
        public DateTime DateTime { get; set; }
        public int? FunctionalFieldId { get; set; } = null;
        public int? LocalCommitteeId { get; set; } = null;
        public bool AllFunctionalFields { get; set; }
        public bool AllLocalCommittees { get; set; }

    }
}
