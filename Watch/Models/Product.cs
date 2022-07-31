using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Watch.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Mount { get; set; }
        public int CategoryId { get; set; }
        public float PriceN { get; set; }
        public float PriceB { get; set; }
        public string Avatar { get; set; }
        public virtual Models.Category Category { get; set; }
        public virtual List<Models.OrderDetail> OrderDetails { get; set; }
    }
}
