using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Insert   
{
    public class Report
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quarter { get; set; }
        public string Mandate { get; set; }
        public string Extension { get; set; }
        public byte[] File { get; set; }
    }
}
