using System;
using System.ComponentModel.DataAnnotations;

namespace AiesecBiH.Database
{
    public abstract class BaseEntity
    {
        [Key]
        public int Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
        
    }
}
