using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using zamazor_core.Models;

namespace zamazor_core.Services
{
    public interface IService<T, R> where T : BaseEntity where R : class
    {
        Task<R> GetByIdAsync(Guid id);
        Task<IEnumerable<R>> GetAllAsync();
        IQueryable<R> Where(Expression<Func<T, bool>> expression);
        Task<bool> AnyAsync(Expression<Func<T, bool>> expression);
        Task<R> AddAsync(T entity);
        Task<IEnumerable<R>> AddRangeAsync(IEnumerable<T> entities);
        Task UpdateAsync(T entity);
        Task RemoveAsync(T entity);
        Task RemoveRangeAsync(IEnumerable<T> entities);
    }
}
