using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
namespace CRM2.Models
{
    public class Invoice
    {
        public int Inv_ID { get; set; }

        [StringLength(50, MinimumLength = 3)]
        [Display(Name = "Invoice name")]
        [Required]
        public string Inv_des { get; set; }

        [RegularExpression(@"^S*\W*$")]
        [Required]
        [StringLength(30)]
        [Display(Name = "Amount")]
        public string Inv_amount { get; set; }

        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        [Display(Name = "Expire Date")]
        public DateTime Inv_date { get; set; }

        public List<Customer> Customers { get; set; }

        public static explicit operator Invoice(Customer v)
        {
            throw new NotImplementedException();
        }
    }
}
