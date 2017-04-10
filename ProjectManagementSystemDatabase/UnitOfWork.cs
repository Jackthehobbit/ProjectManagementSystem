using ProjectManagementSystemDatabase.Repositories;

namespace ProjectManagementSystemDatabase
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ProjectManagementContext _context;

        public UnitOfWork(ProjectManagementContext context)
        {
            _context = context;
            Projects = new ProjectRepository(_context);
        }

        public IProjectRepository Projects { get; private set; }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
