using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Mission7.Models
{
    public class Payment
    {
        [Key]
        [BindNever]
        public int PaymentId { get; set; }

        [BindNever]
        public ICollection<BasketLineItem> Lines { get; set; }
        [Required(ErrorMessage = "Please enter a name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter a first address line")]
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string AddressLine3 { get; set; }
        [Required(ErrorMessage = "Please enter a City")]
        public string City { get; set; }
        [Required(ErrorMessage = "Please enter a State")]
        public string State { get; set; }
        [Required(ErrorMessage = "Please enter a Zip Code")]
        public string Zip { get; set; }
        [Required(ErrorMessage = "Please enter a Country")]
        public string Country { get; set; }
        [BindNever]
        public bool OrderShipped { get; set; }
    }
}
