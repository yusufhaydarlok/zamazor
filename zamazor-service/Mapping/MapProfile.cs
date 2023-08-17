using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.CategoryDTOs;
using zamazor_core.DTOs.CompanyDTOs;
using zamazor_core.DTOs.ProductDTOs;
using zamazor_core.DTOs.ProductEntryDTOs;
using zamazor_core.DTOs.ProductSaleDTOs;
using zamazor_core.DTOs.RoleDTOs;
using zamazor_core.DTOs.UserDTOs;
using zamazor_core.DTOs.WarehouseDTOs;
using zamazor_core.Models;

namespace zamazor_service.Mapping
{
    public class MapProfile : Profile
    {
        public MapProfile()
        {
            #region User
            CreateMap<User, UserDto>().ReverseMap();
            CreateMap<CreateUserDto, User>();
            CreateMap<UpdateUserDto, User>();
            CreateMap<User, UserWithRoleDto>();
            #endregion

            #region Role
            CreateMap<Role, RoleDto>().ReverseMap();
            CreateMap<Role, RoleWithUsersDto>();
            #endregion

            #region Company
            CreateMap<Company, CompanyDto>().ReverseMap();
            CreateMap<CreateCompanyDto, Company>();
            CreateMap<UpdateCompanyDto, Company>();
            #endregion Company

            #region Warehouse
            CreateMap<Warehouse, WarehouseDto>().ReverseMap();
            CreateMap<CreateWarehouseDto, Warehouse>();
            CreateMap<UpdateWarehouseDto, Warehouse>();
            #endregion Warehouse

            #region Product
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<CreateProductDto, Product>();
            CreateMap<UpdateProductDto, Product>();
            CreateMap<Product, ProductWithCategoryDto>();
            #endregion Product

            #region ProductEntry
            CreateMap<ProductEntry, ProductEntryDto>().ReverseMap();
            CreateMap<CreateProductEntryDto, ProductEntry>();
            CreateMap<UpdateProductEntryDto, ProductEntry>();
            #endregion ProductEntry

            #region ProductSale
            CreateMap<ProductSale, ProductSaleDto>().ReverseMap();
            CreateMap<CreateProductSaleDto, ProductSale>();
            CreateMap<UpdateProductSaleDto, ProductSale>();
            #endregion ProductSale

            #region Category
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<CreateCategoryDto, Category>();
            CreateMap<UpdateCategoryDto, Category>();
            CreateMap<Category, CategoryWithProductsDto>();
            #endregion Category
        }
    }
}
