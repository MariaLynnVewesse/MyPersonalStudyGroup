using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MariaPersonalStudyGroup.Models
{
    public class Student
    {
        //Complete the property details
        //This is the "Model" of "data source"

        [Display(Name = "STUDENT NUMBER")] //Add as decorator
        public string StudentNumber { get; set; }

        [Display(Name = "NAME")] //Add as decorator
        public string Name { get; set; }

        [Display(Name = "SURNAME")] //Add as decorator
        public string Surname { get; set; }

        [Display(Name = "EMAIL ADDRESS")] //Add as decorator
        public string Email { get; set; }

        [Display(Name = "LINK TO PERSONAL PAGE")] //Add a new property
        public string MyLink { get; set; }

    }
}