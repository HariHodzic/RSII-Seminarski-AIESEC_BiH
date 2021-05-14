﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class Report:BaseEntity
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quarter { get; set; }
        public string Mandate { get; set; }
        [Required]
        [ForeignKey(nameof(FileModel))]
        public int FileModelId { get; set; }

        public virtual FileModel FileModel { get; set; }
    }
}
