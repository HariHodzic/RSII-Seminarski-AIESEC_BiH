﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class LocalCommittee:BaseEntity
    {
        [DataType(DataType.Date)]
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EstablishmentDate { get; set; }
        [Required]
        public string Name { get; set; }
        public ICollection<Office> Offices { get; set; }
        public IEnumerable<Event> Events { get; set; }
        public IEnumerable<Member> Members { get; set; }

    }
}
