using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleManager.Domain.Entities
{
    public class Products
    {
        public int Id { get; set; }
        public string pName { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; } = true;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime LastUpdatedAt { get; set;} = DateTime.Now;

        public ICollection<ProductImage> Images { get; set; } = new List<ProductImage>();
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;
        public Inventory Inventory { get; set; } = null!;

    }
}
