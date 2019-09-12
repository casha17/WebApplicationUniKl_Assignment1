using System;
 using System.ComponentModel.DataAnnotations;
 
 namespace Assignment1.Models
 {
     public class SizeViewModel
     {
         public double Result { get; set; }
         
         [Required]
         [Range(0,Double.MaxValue , ErrorMessage = "Must only contain numbers")]
         public double Value { get; set; }
     }
 }