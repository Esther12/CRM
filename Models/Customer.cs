using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using CRM2.Models;

namespace CRM2.Models
{
    public class Customer
    {
        public int Cus_ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Last Name")]
        [Required]
        public string Cus_lname { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Required]
        [Display(Name = "First Name")]
        public string Cus_fname { get; set; }

        [RegularExpression(@"[(]\d{3}[)]\d{3}[-]\d{4}$")]
        [Required]
        [StringLength(40)]
        [Display(Name = "Contect Number")]
        public string Cus_phone { get; set; }

        [RegularExpression(@"(.*?)@(.*?)\.(.{2,3})$")]
        [Required]
        [StringLength(40)]
        [Display(Name = "Email")]
        public string Cus_email { get; set; }

        [Required]
        [Display(Name = "Address Street")]
        public string Cus_street { get; set; }

        [Display(Name = "Address City")]
        public string Cus_city { get; set; }

        [Display(Name = "Address Province")]
        public string Cus_pro { get; set; }

        [Display(Name = "Address Country")]
        public string Cus_country { get; set; }

        public List <Employee> Employees { get; set; }

        public int Inv_ID { get; set; }
        public Invoice Invoice { get; set; }
    }
}
