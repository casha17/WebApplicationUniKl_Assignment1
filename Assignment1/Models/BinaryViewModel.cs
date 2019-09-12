using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class BinaryViewModel
    {
        
        [Required]
        [RegularExpression("^[0-1]{1,}$")]
        public int Binary { get; set; }
        
        public string Hex { get; set; }
        
        public int Decimal { get; set; }
    }
}