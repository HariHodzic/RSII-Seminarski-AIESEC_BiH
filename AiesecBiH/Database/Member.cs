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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Username { get; set; }
        [ForeignKey(nameof(Role))]
        [Required]
        public int RoleId { get; set; }
        public Role Role { get; set; }
        public string PasswordHash { get; set; }
        public string PasswordSalt { get; set; }
        [ForeignKey(nameof(FunctionalField))]
        public int? FunctionalFieldId { get; set; }
        public virtual FunctionalField FunctionalField { get; set; }
        [ForeignKey(nameof(LocalCommittee))]
        public int? LocalCommitteeId { get; set; }
        public virtual LocalCommittee LocalCommittee { get; set; }
        public IEnumerable<Task> CreatedTasks { get; set; }
        public IEnumerable<Task> ExecutedTasks { get; set; }

    }
}
