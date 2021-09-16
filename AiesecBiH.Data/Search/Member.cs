using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Search
{
    public class Member:BaseSearchModel
    {
        public string Username { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public char? Gender { get; set; }
        public string PhoneNumber { get; set; }
        public int CityId { get; set; }
        public string CityName { get; set; }
        public int? FunctionalFieldId { get; set; }
        public int? LocalCommitteeId { get; set; }
        public string[] IncludeList { get; set; }

    }
}
