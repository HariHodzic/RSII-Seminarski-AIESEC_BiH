using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Insert
{
    public class Office
    {
        [Required]
        public string Address { get; set; }
        public int Capacity { get; set; }
        public DateTime EstablishmentDate { get; set; }
        [Required]
        public int LocalCommitteeId { get; set; }
    }
}
