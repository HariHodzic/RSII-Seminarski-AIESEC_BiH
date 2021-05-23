using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Response
{
    public class City
    {
        public string Name { get; set; }
        public string Postcode { get; set; }
        public IEnumerable<Office> Offices { get; set; }
    }
}
