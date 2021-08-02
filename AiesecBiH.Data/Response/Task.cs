using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AiesecBiH.Model.Response
{
    public class Task
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; } = false;//After one member executes the task, he can change this field to true. After the creator reviews it, field Active will be changed.

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime Deadline { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public int? MemberExecutorId { get; set; }
        public virtual Member MemberExecutor { get; set; }
    }
}
