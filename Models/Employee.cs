using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CRM2.Models
{
    public class Employee
    {
        public int Emp_ID { get; set; }
        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "Last Name")]
        [Required]
        public string Emp_lname { get; set; }

        [StringLength(50, MinimumLength = 2)]
        [Display(Name = "First Name")]
        [Required]
        public string Emp_fname { get; set; }


        [RegularExpression(@"[(]\d{3}[)]\d{3}[-]\d{4}$")]
        [Required]
        [StringLength(40)]
        [Display(Name = "Contect Number")]
        public string Emp_phone { get; set; }


        [RegularExpression(@"(.*?)@(.*?)\.(.{2,3})$")]
        [Required]
        [StringLength(40)]
        [Display(Name = "Email")]
        public string Emp_email { get; set; }


        public int Cus_ID { get; set; }
        public Customer Customer { get; set; }
    }
}
