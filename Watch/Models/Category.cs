using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Watch.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Decription { get; set; }
        public virtual List<Models.Product> Products { get; set; }
    }
}
