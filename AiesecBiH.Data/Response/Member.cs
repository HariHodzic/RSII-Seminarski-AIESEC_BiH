using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Response
{
    public class Member
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public bool Active { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int FunctionalFieldId { get; set; }
        public int LocalCommitteeId { get; set; }
        public Role Role { get; set; }
        public int RoleId { get; set; }
        public string RoleAbbreviation { get; set; }
        public DateTime CreatedDate { get; set; }
        public IEnumerable<Task> CreatedTasks { get; set; }
        public IEnumerable<Task> ExecutedTasks { get; set; }

    }
}
