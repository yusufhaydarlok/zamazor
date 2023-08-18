using AutoMapper;
using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.UserDTOs;
using zamazor_core.DTOs;
using zamazor_core.Models;
using zamazor_core.Repositories;
using zamazor_core.Services;
using zamazor_core.UnitOfWorks;
using zamazor_core.DTOs.ProductDTOs;

namespace zamazor_service.Services
{
    public class ProductService : Service<Product, ProductDto>, IProductService
    {
        private readonly IUserRepository _userRepository;
        private readonly IMapper _mapper;

        public ProductService(IGenericRepository<Product> repository, IUnitOfWork unitOfWork, IMapper mapper, IUserRepository userRepository) : base(repository, unitOfWork, mapper)
        {
            _mapper = mapper;
            _userRepository = userRepository;
        }

        public async Task<CustomResponseDto<List<ProductWithCategoryDto>>> GetProductsWithCategory()
        {
            var products = await _userRepository.GetUsersWithRole();
            var productsDto = _mapper.Map<List<ProductWithCategoryDto>>(products);
            return CustomResponseDto<List<ProductWithCategoryDto>>.Success(200, productsDto);
        }
    }
}
