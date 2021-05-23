using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Update
{
    public class EventAttendance
    {
        public int EventId { get; set; }
        public string EventName { get; set; }
        public int MemberId { get; set; }
        public string MemberName { get; set; }
        public bool Attended { get; set; } = false;

    }
}
