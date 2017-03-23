using System;
using System.Collections.Generic;
using System.Text;

namespace MuscleFellow.Models
{
    public class OrderDetail
    {
        public int OrderDetailID { get; set; }

        public string OrderID { get; set; }

        public string ProductID { get; set; }

        public int Quantity { get; set; }

        public float UnitPrice { get; set; }

        public float SubTotal { get; set; }

        public DateTime? PlaceDate { get; set; }
    }
}
