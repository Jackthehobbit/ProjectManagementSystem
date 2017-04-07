using ProjectManagementSystemDatabase;
using ProjectManagementSystemDatabase.Entities;
namespace ConsoleTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            ProjectManagementContext context = new ProjectManagementContext();
            Project varTestProject = new Project();
            varTestProject.Code = "TESTPRJ";
            varTestProject.ShortName = "ShortName";
            varTestProject.Name = "This is a full Name";
            varTestProject.Description = "This is a descriptions";

            context.Projects.Add(varTestProject);
            context.SaveChanges();
        
        }
    }
}
