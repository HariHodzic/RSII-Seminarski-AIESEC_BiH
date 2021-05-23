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
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string JMBG { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }
        public char Gender { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public IEnumerable<Task> CreatedTasks { get; set; }
        public IEnumerable<Task> ExecutedTasks { get; set; }

    }
}
