using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class MemberAccount:BaseEntity
    {
        [Required(AllowEmptyStrings = false)]
        [StringLength(maximumLength: 20, MinimumLength = 4)]
        public string Username { get; set; }
        
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }

    }
}
