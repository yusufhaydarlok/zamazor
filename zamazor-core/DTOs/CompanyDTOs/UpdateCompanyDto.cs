using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.Models;

namespace zamazor_core.DTOs.CompanyDTOs
{
    public class UpdateCompanyDto
    {
        public Guid Id { get; set; }
        public string CompanyName { get; set; }
        public string EmailAddress { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
