using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjectManagementSystemDatabase;
using ProjectManagementSystemEntities;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Project newProject = new Project("TestPrj1", "Snam for ", "Name for Test Project", "This is a test Project to test the repo");
            using (UnitOfWork unitOfWork = new UnitOfWork(new ProjectManagementContext()))
            {
                unitOfWork.Projects.Add(newProject);
                unitOfWork.Save();
                Console.WriteLine("Added");
                Console.Read();

                Project editedProj = unitOfWork.Projects.Get("TestPrj1");
                editedProj.Description = "Edited";
                unitOfWork.Save();
                Console.WriteLine("Edited"); 
                Console.Read();

                unitOfWork.Projects.Remove(newProject);
                unitOfWork.Save();
                Console.WriteLine("Removed");
                Console.Read();
            }

        }
    }
}
