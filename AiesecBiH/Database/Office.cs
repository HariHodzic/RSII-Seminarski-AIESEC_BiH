using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class Office:BaseEntity
    {
        [MaxLength(40)]
        public string Address { get; set; }
        public int Capacity { get; set; }

        [DataType(DataType.Date)]
        public DateTime EstablishmentDate { get; set; }

        [Required]
        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
        public City City { get; set; }
        
        [ForeignKey(nameof(LocalCommittee))]
        public int? LocalCommitteeId { get; set; }
        public LocalCommittee LocalCommittee { get; set; }

    }
}
