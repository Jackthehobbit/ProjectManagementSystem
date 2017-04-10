using ProjectManagementSystemDatabase.Repositories;
using ProjectManagementSystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystemDatabase
{
    public class ProjectRepository : Repository<Project>, IProjectRepository
    {
        public ProjectRepository(ProjectManagementContext context) :base(context)
        {
        }

        public Project Get(string projectCode)
        {
            return ProjectManagementContext.Projects.Find(projectCode);
        }

        public ProjectManagementContext ProjectManagementContext
        {
            get { return Context as ProjectManagementContext; }
        }
    }
}
