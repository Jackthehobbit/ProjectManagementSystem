using ProjectManagementSystemDatabase.Entities;
using System.Data.Entity;

namespace ProjectManagementSystemDatabase
{
    public class ProjectManagementContext : DbContext
    {
        public ProjectManagementContext() : base("ProjectManagementConnectionString")
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
