using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment1.Pages.Measurement
{
    public class LoanResult : PageModel
    {
        public LoanViewModel LoanViewModel { get; set; }
        
        
        public void OnGet(LoanViewModel loanViewModel)
        {
            LoanViewModel = loanViewModel;
        }

        public IActionResult OnPost()
        {
            return new RedirectToPageResult("loan");
        }
    }
}