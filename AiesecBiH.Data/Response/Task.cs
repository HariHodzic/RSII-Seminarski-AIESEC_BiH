using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Response
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Executed { get; set; }=false;//After one member executes the task, he can change this field to true. After the creator reviews it, field Active will be changed.

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Deadline { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfExecution { get; set; }
        
        public int MemberCreatorId { get; set; }
        public Member MemberCreator { get; set; }
        public int? MemberExecutorId { get; set; }
        public Member MemberExecutor { get; set; }
        public int FunctionalFieldId { get; set; }
        public FunctionalField FunctionalField { get; set; }
        
        public int LocalCommitteeId { get; set; }
        public LocalCommittee LocalCommittee { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; } = true;

    }
}
