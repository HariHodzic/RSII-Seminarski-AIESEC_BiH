using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Response
{
    public class LocalCommittee
    {
        public int Id { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
        public string Name { get; set; }
    }

}
