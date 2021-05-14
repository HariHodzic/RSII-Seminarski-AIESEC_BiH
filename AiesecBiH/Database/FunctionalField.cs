//using System;
//using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
//using System.Linq;
//using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class FunctionalField:BaseEntity
    {
        [MaxLength(20)]
        public string Name { get; set; }
        [MaxLength(225)]
        public string Description { get; set; }
    }
}
