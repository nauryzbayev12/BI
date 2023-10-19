using BI.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BI.Core.IRepository
{
    public interface IUnitOfWork : IDisposable
    {
        IGenericRepository<Project> Projects { get; }
        Task Save();
    }
}
