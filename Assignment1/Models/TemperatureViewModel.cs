using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class TemperatureViewModel
    {
        
        
        [Required]
        [Range(-50 , 200)]
        public double Fahrenheit { get; set; }
        
        
        [Required]
        [Range(-50 , 100)]
        public double Celcius { get; set; }
    }
}