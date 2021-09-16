using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Update
{
    public class Event
    {
        //[Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool AllMembers { get; set; }
        public DateTime DateTime { get; set; }
        public int FunctionalFieldId { get; set; } 
        public string FunctionalFieldName { get; set; }
        public int LocalCommitteeId { get; set; }
        public string LocalCommitteeName { get; set; }

    }
}
