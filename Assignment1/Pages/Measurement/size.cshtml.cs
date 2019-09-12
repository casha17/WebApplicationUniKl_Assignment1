using System;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment1.Pages.Measurement
{
    public class size : PageModel
    {
        
        
        [BindProperty]
        public SizeViewModel SizeViewModel { get; set; }

        public size()
        {
            SizeViewModel = new SizeViewModel();
        }
        
        public void OnGet( SizeViewModel sizeViewModel)
        {
            SizeViewModel = sizeViewModel;
        }

        public IActionResult OnPost(string from, string to)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            
            if (from == "liter" && to == "deciliter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 10;
            } 
            
            else if (from == "liter" && to == "mililiter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 1000;
            }
            else if (from == "liter" && to == "centiliter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 100;
            }
            
            else if (from == "liter" && to == "liter")
            {
                SizeViewModel.Result = SizeViewModel.Value;
            }
            else if (from == "liter" && to == "kiloliters")
            {
                SizeViewModel.Result = SizeViewModel.Value * 0.001;
            }
            
            else if (from == "mililiter" && to == "mililiter")
            {
                SizeViewModel.Result = SizeViewModel.Value;
            }
            else if (from == "mililiter" && to == "centiliter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 0.1;
            }
            else if (from == "mililiter" && to == "deciliter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 0.01;
            }
            else if (from == "mililiter" && to == "liter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 0.001;
            }
            else if (from == "mililiter" && to == "kiloliters")
            {
                SizeViewModel.Result = SizeViewModel.Value * 0.000001;
            }
            
            
            
            
            
            
            else if (from == "centiliter" && to == "mililiter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 10;
            }
            else if (from == "centiliter" && to == "centiliter")
            {
                SizeViewModel.Result = SizeViewModel.Value;
            }
            else if (from == "centiliter" && to == "deciliter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 0.1;
            }
            else if (from == "centiliter" && to == "liter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 0.01;
            }
            else if (from == "centiliter" && to == "kiloliters")
            {
                SizeViewModel.Result = SizeViewModel.Value * 0.00001;
            }
            
            
            
            
            
            
            
            else if (from == "deciliter" && to == "mililiter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 100;
            }
            else if (from == "deciliter" && to == "centiliter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 10;
            }
            else if (from == "deciliter" && to == "deciliter")
            {
                SizeViewModel.Result = SizeViewModel.Value;
            }
            else if (from == "deciliter" && to == "liter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 0.1;
            }
            else if (from == "deciliter" && to == "kiloliters")
            {
                SizeViewModel.Result = SizeViewModel.Value * 0.0001;
            }
            
            
            
               
            
            else if (from == "kiloliters" && to == "mililiter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 1000000;
            }
            else if (from == "kiloliters" && to == "centiliter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 100000;
            }
            else if (from == "kiloliters" && to == "deciliter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 10000;
            }
            else if (from == "kiloliters" && to == "liter")
            {
                SizeViewModel.Result = SizeViewModel.Value * 1000;
            }
            else if (from == "kiloliters" && to == "kiloliters")
            {
                SizeViewModel.Result = SizeViewModel.Value;
            }
            
            
            return new RedirectToPageResult("size" , SizeViewModel);
        }
    }
}