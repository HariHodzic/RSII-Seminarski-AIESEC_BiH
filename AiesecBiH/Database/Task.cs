using AiesecBiH.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class Task:BaseEntity
    {        
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Executed { get; set; }=false;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Deadline { get; set; }
        public Priority Priority { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime? DateOfExecution { get; set; }

        [Required]
        [ForeignKey(nameof(MemberCreator))]
        public int MemberCreatorId { get; set; }
        public Member MemberCreator { get; set; }

        [ForeignKey(nameof(MemberExecutor))]
        public int? MemberExecutorId { get; set; }
        public virtual Member MemberExecutor { get; set; } = null;

        [ForeignKey(nameof(FunctionalField))]
        public int FunctionalFieldId { get; set; }
        public FunctionalField FunctionalField { get; set; }

        [ForeignKey(nameof(LocalCommittee))]
        public int LocalCommitteeId { get; set; }
        public LocalCommittee LocalCommittee { get; set; }

        [ForeignKey(nameof(Role))]
        public int RoleId { get; set; }
        public Role Role { get; set; }

    }
}
