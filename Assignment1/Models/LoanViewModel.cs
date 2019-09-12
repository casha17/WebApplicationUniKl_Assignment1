using System;
using System.ComponentModel.DataAnnotations;

namespace Assignment1.Models
{
    public class LoanViewModel
    {
        
        
        public double MonthlyInterestRate { get; set; }
        
        public double TotalPayment { get; set; }
        
        public double MonthlyPayment { get; set; }
        
        [Required]
        [Range(0, Double.MaxValue)]
        public double LoanAmount { get; set; }
        
        [Required]
        [Range(0, Double.MaxValue)]
        public double Years { get; set; }
        
        [Required]
        [Range(0, Double.MaxValue)]
        public double AnnualInterestRate { get; set; }
    }
}