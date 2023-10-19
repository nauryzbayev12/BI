using BI.Core;

namespace BI.Domain.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Project> Projects { get; }
        Task Save();
    }
}
