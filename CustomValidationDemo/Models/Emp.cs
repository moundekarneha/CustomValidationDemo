using System;
using System.Collections.Generic;
using System.Linq;
//using System.Web;
using CustomValidationDemo.Models;
//using System.ComponentModel.DataAnnotations;


namespace CustomValidationDemo.Models
{
    public class Emp
    {

        //[Required]
        public string name { get; set; }

        //[CustomValidation(ErrorMessage ="New error msg")]
        [CustomValidation]
        public string msg { get; set; }
    }
}