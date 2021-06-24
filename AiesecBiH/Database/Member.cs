using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Database
{
    public class Member:BaseEntity
    {
        //[Required(AllowEmptyStrings = false)]
        //[StringLength(maximumLength: 20, MinimumLength = 2)]
        public string FirstName { get; set; }

        //[Required(AllowEmptyStrings = false)]
        //[StringLength(maximumLength: 20, MinimumLength = 2)]
        public string LastName { get; set; }

        //[Required]
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        //[Required(AllowEmptyStrings = false)]
        //[DefaultValue("M")]
        public char Gender { get; set; }

        //[EmailAddress]
        //[Required(AllowEmptyStrings = false)]
        public string EmailAddress { get; set; }

        //[Required(AllowEmptyStrings = false)]
        //[DataType(DataType.PhoneNumber)]
        public string PhoneNumber { get; set; }

        //[Required(AllowEmptyStrings = false)]
        //[StringLength(maximumLength: 20, MinimumLength = 4)]
        public string Username { get; set; }
        [ForeignKey(nameof(Role))]
        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        [ForeignKey(nameof(FunctionalField))]
        [Required]
        public int FunctionalFieldId { get; set; }
        public FunctionalField FunctionalField { get; set; }
        [ForeignKey(nameof(LocalCommittee))]
        [Required]
        public int LocalCommitteeId { get; set; }
        public LocalCommittee LocalCommittee { get; set; }
        public IEnumerable<Task> CreatedTasks { get; set; }
        public IEnumerable<Task> ExecutedTasks { get; set; }

    }
}
