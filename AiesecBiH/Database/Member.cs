using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
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
        [StringLength(maximumLength: 12, MinimumLength = 9)]
        public string JMBG { get; set; }

        [Required]
        public DateTime BirthDate { get; set; }
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

        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
        public City City { get; set; }
        public IEnumerable<Task> CreatedTasks { get; set; }
        public IEnumerable<Task> ExecutedTasks { get; set; }

    }
}
