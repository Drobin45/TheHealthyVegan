//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TheHealthyVegan.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Nutrition
    {
        public int NutritionID { get; set; }
        public bool Protein { get; set; }
        public bool Iron { get; set; }
        public bool Calcium { get; set; }
        public bool Vitamin_D { get; set; }
        public bool Vitamin_B12 { get; set; }
        public bool Zinc { get; set; }
    
        public virtual User User { get; set; }
    }
}
