using System;
using System.Collections.Generic;
using System.Text;

namespace MuscleFellow.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }

        public Guid OrderID { get; set; }

        public Guid ProductID { get; set; }

        public int Quantity { get; set; }

        public float UnitPrice { get; set; }

        public float SubTotal { get; set; }

        public DateTime? PlaceDate { get; set; }
    }
}
