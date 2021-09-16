using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Update
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Executed { get; set; }
        public DateTime Deadline { get; set; }
        public DateTime DateOfExecution { get; set; }
        public int MemberCreatorId { get; set; }
        public string MemberCreatorName { get; set; }
        public int? MemberExecutorId { get; set; }
        public string MemberExecutorName { get; set; }
        public int FunctionalFieldId { get; set; }
        public string FunctionalFieldName { get; set; }
        public string LocalCommitteeName { get; set; }
        public int LocalCommitteeId { get; set; }
        public int RoleId { get; set; }
        public string Role { get; set; }

    }
}
