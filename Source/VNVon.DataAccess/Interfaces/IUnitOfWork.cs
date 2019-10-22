using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using VNVon.DataAccess.Models;

namespace VNVon.DataAccess.Interfaces
{
    public interface IUnitOfWork
    {
        IRepositoryBase<T> RepositoryBase<T>() where T : class;
        
        void Save();

        Task CommitAsync();

        Task<bool> CommitAllAsync();

        DbContext Context { get; }
    }
}
