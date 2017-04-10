using System;

namespace ProjectManagementSystemDatabase.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        IProjectRepository Projects { get; }
        int Save();
    }
}
