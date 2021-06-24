using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Response
{
    public class Report
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quarter { get; set; }
        public string Mandate { get; set; }
        [System.ComponentModel.Browsable(false)]
        public byte[] File { get; set; }
        [System.ComponentModel.Browsable(false)]
        public string Extension { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
