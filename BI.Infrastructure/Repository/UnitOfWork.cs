using BI.Database.DatabaseContexts;
using BI.Domain.IRepository;
using BI.Infrastructure.Repository;

namespace BI.Core.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _context;
     
        private IGenericRepository<Project> _projects;

        public UnitOfWork(DatabaseContext context)
        {
            _context = context;
        }   
        public IGenericRepository<Project> Projects => _projects ??= new GenericRepository<Project>(_context);
         
        public void Dispose()
        {
            _context.Dispose();
            GC.SuppressFinalize(this);
        }

        public async Task Save()
        {
            await _context.SaveChangesAsync();
        }
    }
}
