using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class LengthViewModel
    {
        
        
        [Range(0 , Double.MaxValue)]
        public double Centimeter { get; set; }
        
        [Range(0 , Double.MaxValue)]
        public double Meter { get; set; }
        
        [Range(0 , Double.MaxValue)]
        public double Feet { get; set; }
        
        [Range(0 , Double.MaxValue)]
        public double FeetMeter { get; set; }
        
        [Range(0 , Double.MaxValue)]
        public double Mile { get; set; }
        
        [Range(0 , Double.MaxValue)]
        public double MileMeter { get; set; }
    }
}