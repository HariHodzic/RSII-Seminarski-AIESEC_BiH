using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Update
{
    public class Member
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string FirstName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(maximumLength: 20, MinimumLength = 2)]
        public string LastName { get; set; }
        [Required(AllowEmptyStrings = false)]
        [StringLength(maximumLength: 40, MinimumLength = 5)]
        public string Username { get; set; }
        [Required]
        public DateTime BirthDate { get; set; }
        [StringLength(maximumLength: 40, MinimumLength = 5)]
        public string Address { get; set; }
        [Required]
        public char Gender { get; set; }
        public string EmailAddress { get; set; }
        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        [Required]
        public int LocalCommitteeId { get; set; }
        [Required]
        public int FunctionalFieldId { get; set; }
        [Required]
        public int RoleId { get; set; }

    }
}
