using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Insert
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Executed { get; set; }=false;
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Deadline { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime DateOfExecution { get; set; }
        [Required]
        public int MemberCreatorId { get; set; }
        public int? MemberExecutorId { get; set; }
        public int? FunctionalFieldId { get; set; }
        public int? LocalCommitteeId { get; set; }
        public int? RoleId { get; set; }
    }
}
