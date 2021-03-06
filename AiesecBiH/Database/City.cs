using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class City
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50,MinimumLength = 3)]
        public string Name { get; set; }
        public string Postcode { get; set; }
        public int?  LocalCommitteeId { get; set; }
    }
}