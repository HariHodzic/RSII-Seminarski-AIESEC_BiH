using System;
using System.Collections.Generic;
using System.Text;

namespace AiesecBiH.Model.Response
{
    public class Notice
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public int MemberId  { get; set; }
        public string MemberUsername { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
