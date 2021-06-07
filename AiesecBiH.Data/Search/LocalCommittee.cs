using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.Model.Search
{
    public class LocalCommittee:BaseSearchModel
    {
        //[DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        public DateTime EstablishmentDate { get; set; }
        public string CityName { get; set; }
        public int CityId { get; set; }
        
    }
}
