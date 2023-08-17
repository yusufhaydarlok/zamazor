using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zamazor_core.Models
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<User> Users { get; set; }
        public ICollection<Warehouse> Warehouses { get; set; }
    }
}
