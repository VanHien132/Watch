using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Watch.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        public string CustomerId { get; set; }
        public DateTime DateCreate { get; set; }
        public int Status { get; set; }
        public virtual List<Models.OrderDetail> OrderDetails { get; set; }
        public virtual Models.ApplicationUser User { get; set; }
    }
}
