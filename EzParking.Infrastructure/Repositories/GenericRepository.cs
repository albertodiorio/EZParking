using EzParking.Infrastructure.Context;
using EZParking.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EzParking.Infrastructure.Repositories
{
    public class GenericRepository<TEntity>(AppDbContext appDbContext) : IGenericRepository<TEntity> where TEntity : Entity
    {
        public readonly DbSet<TEntity> _dbSet = appDbContext.Set<TEntity>();
        public readonly AppDbContext _appDbContext = appDbContext;

        public async Task<IEnumerable<TEntity>> GetByFilter(Expression<Func<TEntity, bool>> filter)
        {
            var query = _dbSet.AsQueryable();

            if (filter != null)
                query = query
                    .Where(filter)
                    .AsNoTracking();

            return await query.ToListAsync();
        }

        public async Task<TEntity> GetByIdAsync(int id)
        {
            return await _dbSet.FindAsync(id);
        }

        public async Task AddAsync(TEntity entity)
        {
            await _dbSet.AddAsync(entity);

        }

        public async Task RemoveAsync(TEntity entity)
        {
            _dbSet.Remove(entity);
            await _appDbContext.SaveChangesAsync();
        }

        public async Task UpdateAsync(TEntity entity)
        {
            _dbSet.Update(entity);
            await _appDbContext.SaveChangesAsync();
        }
    }
}
