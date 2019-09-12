using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment1.Pages.Measurement
{
    public class Temperature : PageModel
    {
        
        [BindProperty]
        public TemperatureViewModel TemperatureViewModel { get; set; }
        
        public void OnGet(TemperatureViewModel temperatureViewModel)
        {
            TemperatureViewModel = temperatureViewModel;
        }


        public IActionResult OnPostFahr()
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            TemperatureViewModel.Celcius = ConvertFahrenHeitToCelcius(TemperatureViewModel);
            
            return new RedirectToPageResult("Temperature", TemperatureViewModel);
        }
        
        public IActionResult OnPostCelc()
        {
            
            if (!ModelState.IsValid)
            {
                return Page();
            }
            TemperatureViewModel.Fahrenheit = ConvertCelciusToFahrenHeit(TemperatureViewModel);
            return new RedirectToPageResult("Temperature", TemperatureViewModel);
        }


        private double ConvertCelciusToFahrenHeit(TemperatureViewModel temperatureViewModel)
        {
            return temperatureViewModel.Celcius * 1.8 + 32;
        }
        
        private double ConvertFahrenHeitToCelcius(TemperatureViewModel temperatureViewModel)
        {
            return (temperatureViewModel.Fahrenheit - 32) / 1.8;
        }
    }
}