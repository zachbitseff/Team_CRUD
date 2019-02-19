using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Team_CRUD
{
    static class ProjectsDB
    {

        public static List<Projects> GetProjects()
        {
            ProjectContext context = new ProjectContext();

            List<Projects> allProjects = context.Projects.ToList();

        }

        public static void AddProject(Projects p)
        {
            ProjectContext context = new ProjectContext();

            context.Projects.Add(p);
            context.SaveChanges();
        }
    }
}
