using Microsoft.EntityFrameworkCore;
using ShopLine.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ShopLine.Data
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        #region Fields

        protected readonly  ShopLineDBContext _context;
        private DbSet<T> table;

        #endregion

        public GenericRepository(ShopLineDBContext Context)
        {
            _context = Context;
            table = _context.Set<T>();
        }

        #region Public Methods

        public async Task<T> GetById(long id) => await table.FindAsync(id);

        public async Task<T> FirstOrDefault(Expression<Func<T, bool>> predicate)
            => await table.FirstOrDefaultAsync(predicate);

        public async Task<T>   Add(T entity)
        {
            // await Context.AddAsync(entity);
          var objectAdd =  await table.AddAsync(entity);
            return objectAdd.Entity;
        }

        public  IEnumerable<T> GetByPaging(T entity,int pageIndex,int pageSize = 10)
        {
            // await Context.AddAsync(entity);
           return  table.Skip((pageIndex - 1)*pageSize).Take(pageSize).ToList();
            
        }
        public async Task Update(T entity)
        {
            // In case AsNoTracking is used
            table.Attach(entity);
            _context.Entry(entity).State= EntityState.Modified;
        }

        public async Task Remove(T entity)
        {
            table.Remove(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await table.ToListAsync();
        }

        public async Task<IEnumerable<T>> GetWhere(Expression<Func<T, bool>> predicate)
        {
            return await table.Where(predicate).ToListAsync();
        }

        public Task<int> CountAll() => table.CountAsync();

        public Task<int> CountWhere(Expression<Func<T, bool>> predicate)
            => table.CountAsync(predicate);

        #endregion

    }
}