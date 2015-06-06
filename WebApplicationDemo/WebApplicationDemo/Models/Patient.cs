using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;


namespace WebApplicationDemo.Models
{
    public class Patient
    {
        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} characters long.", MinimumLength = 6)]
        [Display(Name = "Patient name")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Age")]
        public int Age { get; set; }

        [Required]
        [Display(Name = "Phone Number")]
        public string Phone { get; set; }

        [Required]
        [Display(Name = "Address")]
        public string Address { get; set; }

        public string ErrorMessage { get; set; }
        public int PatientId { get; set; }
    }
}