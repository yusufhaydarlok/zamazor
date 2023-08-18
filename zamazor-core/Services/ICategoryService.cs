using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.CategoryDTOs;
using zamazor_core.DTOs;
using zamazor_core.Models;

namespace zamazor_core.Services
{
    public interface ICategoryService : IService<Category, CategoryDto>
    {
        public Task<CustomResponseDto<CategoryWithProductsDto>> GetSingleCategoryByIdWithProductsAsync(Guid categoryId);
    }
}
