using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace Team_CRUD
{
    static class ProjectsDB
    {

        public static List<string> GetProjects()
        {
            string connection = 
                ConfigurationManager.ConnectionStrings["ProjectsDB"].ConnectionString;

            using (SqlConnection con = new SqlConnection(connection))
            {
                con.Open();

                //TODO: Finish database code...

                //con.Close(); //closes automatically with using statement
            }

            throw new NotImplementedException();
        }

    }
}
