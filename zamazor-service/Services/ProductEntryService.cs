using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.DTOs.ProductEntryDTOs;
using zamazor_core.Models;
using zamazor_core.Repositories;
using zamazor_core.Services;
using zamazor_core.UnitOfWorks;

namespace zamazor_service.Services
{
    public class ProductEntryService : Service<ProductEntry, ProductEntryDto>
    {
        private readonly IGenericRepository<ProductEntry> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public ProductEntryService(IGenericRepository<ProductEntry> repository, IUnitOfWork unitOfWork, IMapper mapper) : base(repository, unitOfWork, mapper)
        {
            _repository = _repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
    }
}
