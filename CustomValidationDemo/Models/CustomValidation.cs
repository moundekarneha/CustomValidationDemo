using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace CustomValidationDemo.Models
{
    public class CustomValidation:ValidationAttribute
    {
        protected override ValidationResult IsValid(Object value, ValidationContext vc)
        {
            if(vc!=null)
            {
                string str = value.ToString();  
                if(str.Contains("neha"))
                {
                    return ValidationResult.Success;
                }
                ErrorMessage = ErrorMessage ?? "field not contain neha";
                //return new ValidationResult("It must contain sneha");
                return new ValidationResult(ErrorMessage);

            }
            return new ValidationResult("hey all empty fields are here");
        
        }
    }
}