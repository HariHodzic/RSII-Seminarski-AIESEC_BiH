using System;

namespace AiesecBiH.Model.Response
{
    public partial class FunctionalField
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Abbreviation { get; set; }
        public bool Active { get; set; }

    }
}
