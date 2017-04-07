using ProjectManagementSystemDatabase.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagementSystemDatabase
{
    public class ProjectRepo
    {
        public ProjectRepo()
        {
            ProjectManagementContext con = new ProjectManagementContext();

            Project prj = new Project();
            prj.Code = "TEST1";
            prj.Name = "THIS IS A FULL NAME";
            prj.ShortName = "this is a SNAM";
            prj.Description = "Desc";

            con.Projects.Add(prj);

            con.SaveChanges();
        }
    }
}
