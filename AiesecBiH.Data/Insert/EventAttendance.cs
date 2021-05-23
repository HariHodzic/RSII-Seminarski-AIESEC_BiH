using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Insert
{
    public class EventAttendance
    {
        [Required]
        public int EventId { get; set; }
        [Required]
        public int MemberId { get; set; }
        public bool Attended { get; set; } = false;

    }
}
