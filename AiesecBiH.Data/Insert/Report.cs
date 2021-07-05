using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Insert   
{
    public class Report
    {
        [Required]
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quarter { get; set; }
        public string Mandate { get; set; }
        [Required]
        public string Extension { get; set; }
        [Required]
        public byte[] File { get; set; }
    }
}
