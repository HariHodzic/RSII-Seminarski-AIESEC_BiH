using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Response
{
    public class Office
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public int Capacity { get; set; }
        public DateTime EstablishmentDate { get; set; }
        public int? LocalCommitteeId { get; set; }
        public virtual LocalCommittee LocalCommittee { get; set; }
        public string LocalCommitteeName => LocalCommittee?.Name;
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
