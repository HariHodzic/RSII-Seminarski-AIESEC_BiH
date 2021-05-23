using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Response
{
    public class Event
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsOnline { get; set; }
        public bool AllFunctionalFields { get; set; }
        public bool AllLocalCommittees { get; set; }
        public DateTime DateTime { get; set; }
        public int FunctionalFieldId { get; set; }
        public FunctionalField FunctionalField { get; set; }
        public string FunctionalFieldName { get; set; }
        public int LocalCommitteeId { get; set; }
        public LocalCommittee LocalCommittee{ get; set; }
        public string LocalCommitteeName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; } = true;

    }
}
