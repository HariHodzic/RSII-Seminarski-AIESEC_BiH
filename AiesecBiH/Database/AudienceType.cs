using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class AudienceType:BaseEntity
    {
        public string Name { get; set; }
        [ForeignKey(nameof(FunctionalField))]
        public int?  FunctionalFieldId { get; set; }
        public FunctionalField FunctionalField { get; set; }
        [ForeignKey(nameof(LocalCommittee))]
        public int? LocalCommitteeId { get; set; }
        public LocalCommittee LocalCommittee { get; set; }
        [ForeignKey(nameof(Role))]
        public int? RoleID { get; set; }
        public Role Role { get; set; }
    }
}
