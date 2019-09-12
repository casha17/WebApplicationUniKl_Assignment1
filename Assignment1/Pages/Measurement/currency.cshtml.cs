using System;
using System.Globalization;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment1.Pages.Measurement
{
    public class currency : PageModel
    {
        [BindProperty]
        public CurrencyViewModel CurrencyViewModel { get; set; }
        
        
        
        public void OnGet(CurrencyViewModel currencyViewModel)
        {
            Console.WriteLine();
        }

        public IActionResult OnPost()
        {

            
            if (CurrencyViewModel.Danish > 0)
            {
                ConvertCurrencyDanish(CurrencyViewModel);
            } 
            else if (CurrencyViewModel.Dollars > 0)
            {
                ConvertCurrencyDollars(CurrencyViewModel);
            }
            
            else if (CurrencyViewModel.Euro > 0)
            {
                ConvertCurrencyEuro(CurrencyViewModel);
            }
            
            else if (CurrencyViewModel.Pound > 0)
            {
                ConvertCurrencyPound(CurrencyViewModel);
            }
            
            else if (CurrencyViewModel.Ringit > 0)
            {
                ConvertCurrencyRingit(CurrencyViewModel);
            }
            
            else if (CurrencyViewModel.Thai > 0)
            {
                ConvertCurrencyThai(CurrencyViewModel);
            }
            return new RedirectToPageResult("currencyResult", CurrencyViewModel);

            
        }

        public void ConvertCurrencyDanish(CurrencyViewModel currencyViewModel)
        {

            currencyViewModel.Dollars = currencyViewModel.Danish * 0.15;
            currencyViewModel.Pound = currencyViewModel.Danish * 0.12;
            currencyViewModel.Euro = currencyViewModel.Danish * 0.13;
            currencyViewModel.Ringit = currencyViewModel.Danish * 0.62;
            currencyViewModel.Thai = currencyViewModel.Danish * 4.49;
            currencyViewModel.Danish = currencyViewModel.Danish; 
            
        }
        public void ConvertCurrencyRingit(CurrencyViewModel currencyViewModel)
        {
            currencyViewModel.Dollars = currencyViewModel.Ringit * 0.24;
            currencyViewModel.Pound = currencyViewModel.Ringit * 0.19;
            currencyViewModel.Euro = currencyViewModel.Ringit * 0.21;
            currencyViewModel.Ringit = currencyViewModel.Ringit;
            currencyViewModel.Thai = currencyViewModel.Ringit * 7.27;
            currencyViewModel.Danish = currencyViewModel.Ringit * 1.62;
        }
        public void ConvertCurrencyEuro(CurrencyViewModel currencyViewModel)
        {
            currencyViewModel.Dollars = currencyViewModel.Euro * 1.11;
            currencyViewModel.Pound = currencyViewModel.Euro * 0.91;
            currencyViewModel.Euro = currencyViewModel.Euro;
            currencyViewModel.Ringit = currencyViewModel.Euro * 4.65;
            currencyViewModel.Thai = currencyViewModel.Euro * 33.82;
            currencyViewModel.Danish = currencyViewModel.Euro * 7.53;
        }
        public void ConvertCurrencyDollars(CurrencyViewModel currencyViewModel)
        {
            currencyViewModel.Dollars = currencyViewModel.Dollars;
            currencyViewModel.Pound = currencyViewModel.Dollars * 0.81;
            currencyViewModel.Euro = currencyViewModel.Dollars * 0.90;
            currencyViewModel.Ringit = currencyViewModel.Dollars * 4.18;
            currencyViewModel.Thai = currencyViewModel.Dollars * 30.39;
            currencyViewModel.Danish = currencyViewModel.Dollars * 6.77;
        }
        public void ConvertCurrencyThai(CurrencyViewModel currencyViewModel)
        {
            currencyViewModel.Dollars = currencyViewModel.Thai * 0.034;
            currencyViewModel.Pound = currencyViewModel.Thai * 0.032;
            currencyViewModel.Euro = currencyViewModel.Thai * 0.03;
            currencyViewModel.Ringit = currencyViewModel.Thai * 0.14;
            currencyViewModel.Thai = currencyViewModel.Thai;
                currencyViewModel.Danish = currencyViewModel.Thai * 0.22;
        }
        public void ConvertCurrencyPound(CurrencyViewModel currencyViewModel)
        {
            currencyViewModel.Dollars = currencyViewModel.Pound * 1.23;
            currencyViewModel.Pound = currencyViewModel.Pound;
            currencyViewModel.Euro = currencyViewModel.Pound * 1.10;
            currencyViewModel.Ringit = currencyViewModel.Pound * 5.14;
            currencyViewModel.Thai = currencyViewModel.Pound * 37.34;
            currencyViewModel.Danish = currencyViewModel.Pound * 8.31;
        }
    }
}