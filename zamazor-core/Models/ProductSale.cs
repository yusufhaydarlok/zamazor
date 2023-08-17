using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamazor_core.Models
{
    public class ProductSale : BaseEntity
    {
        public int QuantitySold { get; set; }
        public DateTime SaleDate { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalProfit { get; set; }
        public Guid SoldByUserId { get; set; }
        public User SoldByUser { get; set; }
    }
}
