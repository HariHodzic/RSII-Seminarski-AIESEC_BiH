using System;
using System.ComponentModel.DataAnnotations;
using AiesecBiH.Model.CustomValidationAttributes;


namespace AiesecBiH.Model.Insert
{
    public class FunctionalField
    {
        [Required]
        [StringLength(20, MinimumLength = 5)]
        [DataType(DataType.Text)]
        [LettersOnly]
        public string Name { get; set; }

        [MaxLength(225)]
        public string Description { get; set; }

        [StringLength(7, MinimumLength = 1)]
        [Required]
        public string Abbreviation { get; set; }
    }
}
