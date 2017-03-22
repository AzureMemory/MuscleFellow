using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MuscleFellow.Models
{
    public class ShipAddress
    {
        public int AddressID { get; set; }

        public string UserID { get; set; }

        public string Province { get; set; }

        public string City { get; set; }

        [Required]
        [StringLength(200,MinimumLength = 4)]
        public string Address { get; set; }

        public string ZipCode { get; set; }

        [Required]
        [StringLength(200, MinimumLength = 2)]
        public string Receiver { get; set; }

        [Required]
        [Phone]
        public string PhoneNumber { get; set; }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
