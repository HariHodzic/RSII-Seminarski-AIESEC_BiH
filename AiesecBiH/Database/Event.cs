using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class Event:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public DateTime DateTime { get; set; }

        [ForeignKey(nameof(FunctionalField))]
        public int? FunctionalFieldId { get; set; }
        public FunctionalField? FunctionalField { get; set; }

        [ForeignKey(nameof(LocalCommittee))]
        public int? LocalCommitteeId { get; set; }
        public LocalCommittee? LocalCommittee { get; set; }
        
    }
}
