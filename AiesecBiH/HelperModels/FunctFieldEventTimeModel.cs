using Microsoft.ML.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AiesecBiH.HelperModels
{
    public class FunctFieldEventTimeModel
    {
        [KeyType(2000)]
        public uint FunctionalFieldId { get; set; }

        [KeyType(2000)]
        public uint EventTimeUid { get; set; }

        public float Label { get; set; }
    }
}
