using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Search

{
    public class Event:BaseSearchModel
    {
        public string Name { get; set; }
        public bool IsOnline { get; set; }
        public bool AllMembers { get; set; }
        public DateTime DateTime { get; set; }
        public int FunctionalFieldId { get; set; }
        public int LocalCommitteeId { get; set; }
        public bool AllFunctionalFields { get; set; }
        public bool AllLocalCommittees { get; set; }

    }
}
