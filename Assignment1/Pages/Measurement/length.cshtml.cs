using System;
using Assignment1.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Assignment1.Pages.Measurement
{
    public class length : PageModel
    {

        [BindProperty] 
        public LengthViewModel LengthViewModel { get; set; }

        public void OnGet(LengthViewModel lengthViewModel)
        {
            LengthViewModel = lengthViewModel;
        }

        public IActionResult OnPostCentimeter()
        
        
        {

            if (!ModelState.IsValid)
            {
                return Page();
            }
            
            LengthViewModel.Meter = ConvertCentimeterToMeter(LengthViewModel.Centimeter);

            return new RedirectToPageResult("length", LengthViewModel);
        }

        public IActionResult OnPostMeter()
        {
            LengthViewModel.Centimeter = ConvertMeterToCentimeter(LengthViewModel.Meter);

            return new RedirectToPageResult("length", LengthViewModel);
        }

        public IActionResult OnPostFeet()
        {
            LengthViewModel.FeetMeter = ConvertFeetToMeter(LengthViewModel.Feet);
            return new RedirectToPageResult("length", LengthViewModel);
        }

        public IActionResult OnPostMeterToFeet()
        {
            LengthViewModel.Feet = ConvertMeterToFeet(LengthViewModel.FeetMeter);
            return new RedirectToPageResult("length", LengthViewModel);
        }

        public IActionResult OnPostMile()
        {
            LengthViewModel.MileMeter = ConvertMileToMeter(LengthViewModel.Mile);
            return new RedirectToPageResult("length", LengthViewModel);
        }

        public IActionResult OnPostMeterToMile()
        {
            LengthViewModel.Mile = ConvertMeterToMile(LengthViewModel.MileMeter);
            return new RedirectToPageResult("length", LengthViewModel);

        }

        private double ConvertCentimeterToMeter(double centimeter)
        {
            return centimeter / 100;
        }

        private double ConvertMeterToCentimeter(double  meter)
        {
            return meter * 100;
        }

        private double ConvertFeetToMeter(double feet)
        {
            return feet * 0.3048;
        }

        private double ConvertMeterToFeet(double meter)
        {
            return meter / 0.3048;
        }

        private double ConvertMileToMeter(double mile)
        {
            return mile / 0.00062137;
        }

        private double ConvertMeterToMile(double meter)
        {
            return meter * 0.00062137;
        }
    }
}