using System;
using System.Collections.Generic;
using System.Text;

namespace AiesecBiH.Model.Response
{
    public class MemberLL:Member
    {
        public virtual FunctionalField FunctionalField { get; set; }
        public string FunctionalFieldName => FunctionalField?.Name;
        public virtual LocalCommittee LocalCommittee { get; set; }
        public string LocalCommitteeName => LocalCommittee?.Name;
    }
}
