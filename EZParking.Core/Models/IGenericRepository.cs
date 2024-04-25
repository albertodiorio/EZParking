using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EZParking.Core.Models
{
    public interface IGenericRepository<TEntity> where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> GetByFilter(Expression<Func<TEntity, bool>> filter);
        Task<TEntity> GetByIdAsync(int id);
        Task AddAsync(TEntity entity);
        Task RemoveAsync(TEntity entity);
        Task UpdateAsync(TEntity entity);
    }
}
