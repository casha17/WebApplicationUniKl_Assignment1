using System;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment1.Pages.Measurement
{
    public class loan : PageModel
    {
        [BindProperty]
        public LoanViewModel LoanViewModel { get; set; }
        
        
        public void OnGet()
        {
            
        }


        public IActionResult OnPost()

        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            CalculateLoan(LoanViewModel);
            return new RedirectToPageResult("loanResult" , LoanViewModel);
        }


        private void CalculateLoan(LoanViewModel loanViewModel)
        {
            loanViewModel.MonthlyInterestRate = loanViewModel.AnnualInterestRate / 12;

            loanViewModel.MonthlyPayment = loanViewModel.LoanAmount * loanViewModel.MonthlyInterestRate /
                                           (1 - 1 / Math.Pow(1 + loanViewModel.MonthlyInterestRate,
                                                loanViewModel.Years * 12));

            loanViewModel.TotalPayment = loanViewModel.MonthlyPayment * loanViewModel.Years * 12;

        }
    }
}