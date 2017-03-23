using System;
using System.Collections.Generic;
using System.Text;

namespace MuscleFellow.Models
{
    public class CartItem
    {
        public string CartID { get; set; }

        public string UserID { get; set; }

        public string SessionID { get; set; }

        public string ProductID { get; set; }

        public string ProductName { get; set; }

        public string ThumbImagePath { get; set; }

        public int Quantity { get; set; }

        public float UnitPrice { get; set; }

        public float SubTotal { get; set; }

        public DateTime LastUpdatedDateTime { get; set; }

        public DateTime CreatedDateTime { get; set; }
    }
}
