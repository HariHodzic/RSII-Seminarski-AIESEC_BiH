using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Response
{
    public class EventAttendance
    {
        public int Id { get; set; }
        public int EventId { get; set; }
        public Event Event { get; set; }
        public string EventName { get; set; }
        public DateTime EventDate { get; set; }
        [Required]
        [ForeignKey(nameof(Member))]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public string MemberName { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; } = true;

    }
}
