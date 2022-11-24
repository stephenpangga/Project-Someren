using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Collections.ObjectModel;
using SomerenModel;

namespace SomerenDAL
{
    public class Student_DAO : Base
    {
        //tudors part

        public List<Student> Db_Get_All_Students()
        {
            string query = "SELECT * FROM Students";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Student> ReadTables(DataTable dataTable)
        {
            List<Student> students = new List<Student>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Student student = new Student()
                {
                    Number = (int)dr["Student Id"],
                    FirstName = (string)(dr["First Name"].ToString()),
                    LastName = (string)dr["Last Name"],
                    Group = (string)dr["Class"],
                    Contact = (string)dr["Contact info"]
                };
                students.Add(student);
            }
            return students;
        }
    }
}
