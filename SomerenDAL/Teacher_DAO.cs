using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Teacher_DAO : Base
    {
        //stephen's part

        public List<Teacher> Db_Get_All_Teachers()
        {
            string query = "SELECT [Teacher Id], FirstName,LastName,Supervisor, Department FROM Teacher";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Teacher> ReadTables(DataTable dataTable)
        {
            List<Teacher> teachers = new List<Teacher>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Teacher teacher = new Teacher()
                {
                    Number = (int)dr["Teacher Id"],
                    firstName = (String)(dr["FirstName"].ToString()),
                    lastName = (String)(dr["LastName"].ToString()),
                    supervisor =(String)(dr["Supervisor"].ToString()),
                    Department = (String)(dr["Department"].ToString()),
                    //Contact = (int)dr["Contact info"]
                };
                teachers.Add(teacher);
            }
            return teachers;
        }

    }
}
