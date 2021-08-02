using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class Notice
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        [ForeignKey(nameof(Member))]
        public int MemberId { get; set; }
        public Member Member { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
