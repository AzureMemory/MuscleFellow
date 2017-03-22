using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace MuscleFellow.Models
{
    public class Order
    {
        [Key]
        public Guid OrderID { get; set; }

        public string UserID { get; set; }

        public List<OrderDetail> OrderItems { get; set; }

        [MaxLength(128)]
        public string Address { get; set; }

        public string TotalPrice { get; set; }

        public OrderStatus OrderStatus { get; set; }

        public DateTime? OrderDate { get; set; }
    }

    public enum OrderStatus : int
    {
        PendingPayment,
        PedndingShipment,
        PedndingEvaluated,
        Closed,
        Cancelled
    }
}
