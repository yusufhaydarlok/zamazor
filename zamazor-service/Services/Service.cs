using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.Models;
using zamazor_core.Repositories;
using zamazor_core.Services;
using zamazor_core.UnitOfWorks;
using zamazor_service.Exceptions;

namespace zamazor_service.Services
{
    public class Service<T, R> : IService<T, R> where T : BaseEntity where R : class
    {
        private readonly IGenericRepository<T> _repository;
        private readonly IUnitOfWork _unitOfWork;
        private readonly IMapper _mapper;

        public Service(IGenericRepository<T> repository, IUnitOfWork unitOfWork, IMapper mapper)
        {
            _repository = repository;
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }

        public async Task<R> AddAsync(T entity)
        {
            await _repository.AddAsync(entity);
            await _unitOfWork.CommitAsync();
            var dto = _mapper.Map<R>(entity);
            return dto;
        }

        public async Task<IEnumerable<R>> AddRangeAsync(IEnumerable<T> entities)
        {
            await _repository.AddRangeAsync(entities);
            await _unitOfWork.CommitAsync();
            var dtos = _mapper.Map<IEnumerable<R>>(entities);
            return dtos;
        }

        public async Task<bool> AnyAsync(Expression<Func<T, bool>> expression)
        {
            return await _repository.AnyAsync(expression);
        }

        public async Task<IEnumerable<R>> GetAllAsync()
        {
            var entities = await _repository.GetAll().ToListAsync();
            var dtos = _mapper.Map<IEnumerable<R>>(entities);
            return dtos;
        }

        public async Task<R> GetByIdAsync(Guid id)
        {
            var entity = await _repository.GetByIdAsync(id);

            if (entity == null)
            {
                throw new NotFoundExcepiton($"{typeof(T).Name}({id}) not found");
            }
            var dto = _mapper.Map<R>(entity);
            return dto;
        }

        public async Task RemoveAsync(T entity)
        {
            _repository.Remove(entity);
            await _unitOfWork.CommitAsync();
        }

        public async Task RemoveRangeAsync(IEnumerable<T> entities)
        {
            _repository.RemoveRange(entities);
            await _unitOfWork.CommitAsync();
        }

        public async Task UpdateAsync(T entity)
        {
            _repository.Update(entity);
            await _unitOfWork.CommitAsync();
        }

        public IQueryable<R> Where(Expression<Func<T, bool>> expression)
        {
            var queryable = _repository.Where(expression);
            var dtoQueryable = queryable.ProjectTo<R>(_mapper.ConfigurationProvider);
            return dtoQueryable;
        }
    }
}
