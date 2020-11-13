using ShopLine.Domain;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopLine.Data.UnitOfWork
{
    public class UnitOfWork<T> : IUnitOfWork<T> where T : BaseEntity
    {
        private ShopLineDBContext dbContext;
        public IGenericRepository<T> _rep { get; set; }
        public UnitOfWork(ShopLineDBContext _dbContext)
        {
            dbContext = _dbContext;
            _rep = new GenericRepository<T>(dbContext);
        }

        public Task<int> SaveChangesAsync()
        {
          return dbContext.SaveChangesAsync();
        }

        public int SaveChange()
        {
            return dbContext.SaveChanges();
        }

        public void Dispose()
        {
            dbContext.Dispose();
        }
    }
}
