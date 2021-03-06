using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Insert
{
    public class Member
    {   
        [Required(AllowEmptyStrings = false)]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }
        [StringLength(maximumLength: 40, MinimumLength = 5)]
        public string Address { get; set; } = null;
        [DefaultValue("M")]
        public char Gender { get; set; }

        [EmailAddress]
        [Required(AllowEmptyStrings = false)]
        public string EmailAddress { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; } = null;
        [Required]
        public int RoleId { get; set; }
        [Required]
        public int FunctionalFieldId { get; set; }
        [Required]
        public int LocalCommitteeId { get; set; }
        public bool Active { get; set; } = true;
    }
}
