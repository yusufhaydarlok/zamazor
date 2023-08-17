using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.CompanyDTOs;
using zamazor_core.Models;

namespace zamazor_core.Services
{
    public interface ICompanyService : IService<Company, CompanyDto>
    {
    }
}
