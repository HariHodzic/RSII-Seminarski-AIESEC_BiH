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
        public bool? Executed { get; set; }
        public int MemberCreatorId { get; set; }
        public int? MemberExecutorId { get; set; }
        public int FunctionalFieldId { get; set; }
        public int LocalCommitteeId { get; set; }
        public int RoleId { get; set; }

    }
}
