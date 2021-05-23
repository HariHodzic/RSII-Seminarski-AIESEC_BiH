using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Search

{
    public class Task:BaseSearchModel

    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Executed { get; set; }//After one member executes the task, he can change this field to true. After the creator reviews it, field Active will be changed.
        public DateTime Deadline { get; set; }
        public DateTime DateOfExecution { get; set; }
        public int MemberCreatorId { get; set; }
        public string MemberCreatorName { get; set; }
        public int? MemberExecutorId { get; set; }
        public string MemberExecutor { get; set; }
        public int FunctionalFieldId { get; set; }
        public string FunctionalFieldName { get; set; }
        public int LocalCommitteeId { get; set; }
        public string LocalCommitteeName { get; set; }
        public int RoleId { get; set; }
        public string RoleName { get; set; }

    }
}
