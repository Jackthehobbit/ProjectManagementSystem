using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProjectManagementSystemDatabase.Entities.Project;

namespace ProjectManagementSystemDatabase
{
    public class ProjectManagementContext
    {
        public ProjectManagementContext() : base("ProjectManagementConnectionString")
        {

        }

        public DbSet<Project> Project { get; set; }
    }
}
