using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleManager.Domain.Entities
{
    public class ProductImage
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Products Product { get; set; } = null!;
        public bool IsMain { get; set; }        // true = ảnh chính
        public int DisplayOrder { get; set; }   // thứ tự hiển thị
    }
}
