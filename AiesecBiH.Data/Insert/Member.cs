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
        [Required(AllowEmptyStrings = false)]
        [StringLength(maximumLength: 12, MinimumLength = 9)]
        public string JMBG { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }

        [Required(AllowEmptyStrings = false)]
        [StringLength(maximumLength: 30, MinimumLength = 3)]
        public string Address { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DefaultValue("M")]
        public char Gender { get; set; }

        [EmailAddress]
        [Required(AllowEmptyStrings = false)]
        public string EmailAddress { get; set; }

        [Required(AllowEmptyStrings = false)]
        [DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
    }
}
