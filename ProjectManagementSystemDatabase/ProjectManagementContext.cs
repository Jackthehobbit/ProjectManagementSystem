using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProjectManagementSystemDatabase.Entities;

namespace ProjectManagementSystemDatabase
{
    public class ProjectManagementContext :DbContext
    {
        public ProjectManagementContext() : base("ProjectManagementConnectionString")
        {

        }

        public DbSet<Project> Projects { get; set; }
    }
}
