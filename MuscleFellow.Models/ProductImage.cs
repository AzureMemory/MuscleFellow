using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MuscleFellow.Models
{
    public class ProductImage
    {
        [Key]
        public int ImageID { get; set; }

        public Guid ProductID { get; set; }

        public string RelativeUrl { get; set; }

        public string Comments { get; set; }
    }
}
