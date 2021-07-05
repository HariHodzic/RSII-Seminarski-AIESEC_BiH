//using System;
//using System.Collections.Generic;

using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class FunctionalField:BaseEntity
    {
        [Required]
        [StringLength(30, MinimumLength = 4)]
        public string Name { get; set; }

        [MaxLength(225)]
        public string Description { get; set; }

        [StringLength(7, MinimumLength = 1)]
        [Required]
        public string Abbreviation { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public ICollection<Member> Members { get; set; }

    }
}
