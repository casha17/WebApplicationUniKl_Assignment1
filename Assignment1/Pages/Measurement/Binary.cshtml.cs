using System;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment1.Pages.Measurement
{


    public class Binary : PageModel
    {
        
        [BindProperty]
        public BinaryViewModel BinaryViewModel { get; set; }
        
        public void OnGet(BinaryViewModel binaryViewModel)
        {
            BinaryViewModel = binaryViewModel;
        }


        public IActionResult OnPostDec()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            ConvertToDecimal(BinaryViewModel);
            
            return new RedirectToPageResult("Binary", BinaryViewModel);
            
        }
        
        public IActionResult OnPostHex()
        {
            ConvertToHex(BinaryViewModel);
            
            return new RedirectToPageResult("Binary", BinaryViewModel);
            
        }



        public void ConvertToDecimal(BinaryViewModel binaryViewModel)
        {
            binaryViewModel.Decimal = Convert.ToInt32(binaryViewModel.Binary.ToString(), 2);
          
        }

        public void ConvertToHex(BinaryViewModel binaryViewModel)
        {
            ConvertToDecimal(binaryViewModel);
            binaryViewModel.Hex = binaryViewModel.Decimal.ToString("X");
        }
    }
}