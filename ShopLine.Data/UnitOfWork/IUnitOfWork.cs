using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ShopLine.Data.UnitOfWork
{
    public interface IUnitOfWork<T> : IDisposable
    {
        Task<int> SaveChangesAsync();
        int SaveChange();
        public void Dispose();
    }
}
