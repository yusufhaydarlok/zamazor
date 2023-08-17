using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.Models;
using zamazor_core.DTOs;
using zamazor_core.DTOs.ProductDTOs;

namespace zamazor_core.Services
{
    public interface IProductService : IService<Product, ProductDto>
    {
        Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory();
    }
}
