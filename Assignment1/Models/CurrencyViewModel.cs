using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class CurrencyViewModel
    {
        
       
        [RegularExpression(@"^(\s*|\d+)$", ErrorMessage = "Only numbers")]
        public double Danish { get; set; }

       
        public double Ringit { get; set; }
    
        
        public double Euro { get; set; }
    
       
        public double Dollars { get; set; }
      
       
        public double Thai { get; set; }
     
        
        public double Pound { get; set; }
        
    }
}