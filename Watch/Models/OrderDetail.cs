using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Watch.Models
{
    public class OrderDetail
    {

        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public float Amount { get; set; }
        public virtual Models.Order Order { get; set; }
        public virtual Models.Product Product { get; set; }
    }
}
