using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Response
{
    public class Report
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public int Quarter { get; set; }
        public string Mandate { get; set; }
        public int FileModelId { get; set; }
        public virtual FileModel FileModel { get; set; }
        public DateTime CreatedDate { get; set; }

    }
}
