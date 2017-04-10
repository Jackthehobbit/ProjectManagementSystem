using ProjectManagementSystemEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystemDatabase.Repositories
{
    public interface IProjectRepository : IRepository<Project>
    {
        Project Get(string code);
    }
}
