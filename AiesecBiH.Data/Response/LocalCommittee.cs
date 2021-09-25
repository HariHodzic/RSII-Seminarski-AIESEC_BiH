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
        [DataType(DataType.Date)]
        public DateTime EstablishmentDate { get; set; }
        public string Name { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Active { get; set; }
    }

}
