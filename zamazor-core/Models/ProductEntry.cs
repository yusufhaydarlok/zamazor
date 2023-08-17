using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamazor_core.Models
{
    public class ProductEntry : BaseEntity
    {
        public int Quantity { get; set; }
        public DateTime EntryDate { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal TotalCost { get; set; }
        public Guid EnteredByUserId { get; set; }
        public User EnteredByUser { get; set; }  
    }
}
