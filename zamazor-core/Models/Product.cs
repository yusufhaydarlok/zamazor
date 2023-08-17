using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamazor_core.Models
{
    public class Product : BaseEntity
    {
        public string ProductName { get; set; }
        public string StockCode { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal SalePrice { get; set; }
        public Guid SupplierId { get; set; }
        public Company Supplier { get; set; }
        public Guid CategoryId { get; set; }
        public Category Category { get; set; }
        public ICollection<ProductEntry> ProductEntries { get; set; }
        public ICollection<ProductSale> ProductSales { get; set; }
    }
}
