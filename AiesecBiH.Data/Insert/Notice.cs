using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AiesecBiH.Model.Insert
{
    public class Notice
    {
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 5)]
        public string Title { get; set; }
        [Required]
        [StringLength(maximumLength: 40, MinimumLength = 5)]
        public string Body { get; set; }
        public DateTime CreatedDate { get; set; }
        public int MemberId { get; set; }
    }
}
