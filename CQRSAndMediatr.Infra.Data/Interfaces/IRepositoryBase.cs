using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CQRSAndMediatr.Infra.Data.Interfaces
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        void Add(TEntity obj);
        Task<TEntity> GetByIdAsync(Guid id);
        Task<IEnumerable<TEntity>> GetAllAsync();
        void Update(TEntity obj);
        void Remove(TEntity obj);
        Task<bool> SaveChangesAsync();
    }
}
