using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment1.Pages.Measurement
{
    public class currencyResult : PageModel
    {
        public CurrencyViewModel CurrencyViewModel { get; set; }
        
        
        public void OnGet(CurrencyViewModel currencyViewModel)
        {
            CurrencyViewModel = currencyViewModel;
        }

        public IActionResult OnPost()
        {
            return new RedirectToPageResult("currency");
        }
    }
}