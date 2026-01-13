using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleManager.Domain.Entities
{
    public class Inventory
    {
        public int Id { get; set; }

        public int ProductId { get; set; }
        public Products Product { get; set; } = null!;

        public int QuantityInStock { get; set; }     // Tổng tồn
        public int QuantityReserved { get; set; }    // Đã đặt

        public DateTime LastUpdated { get; set; } = DateTime.Now;

        public int Available => QuantityInStock - QuantityReserved;
    }
}
