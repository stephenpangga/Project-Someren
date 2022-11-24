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
    public class Supervisors_DAO : Base
    {

        public void AddSupervisor(int supervisorID, int teacherID)
        {
            try
            {

                //adding in supervisor                
                string query = "INSERT INTO Supervisor VALUES (" + supervisorID + "," + teacherID + ")";
                SqlParameter[] sqlParameters = new SqlParameter[0];
                ExecuteEditQuery(query, sqlParameters);

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Record has been already added");
            }

        }
        public void DeleteSupervisor(int supervisor_id)
        {
            //delete from timetable
            string query = "DELETE FROM TimeTable WHERE Supervisor=" + supervisor_id;
            SqlParameter[] sqlParameters = new SqlParameter[0];
            ExecuteEditQuery(query, sqlParameters);

            //Delete from supervisors
            string query1 = "DELETE FROM Supervisors WHERE Supervisor_ID=" + supervisor_id;
            SqlParameter[] sqlParameters1 = new SqlParameter[0];
            ExecuteEditQuery(query1, sqlParameters1);
        }


        public List<Supervisors> GetAllSupervisors()
        {
            //connecting supervisors with teachers using inner join.
            string query = "SELECT Supervisors.Supervisor_ID, Teacher.FirstName, Teacher.LastName FROM Supervisors INNER JOIN Teacher ON Supervisors.Teacher_ID = Teacher.[Teacher Id]";
            SqlParameter[] sqlParameters = new SqlParameter[0];
            return ReadTables(ExecuteSelectQuery(query, sqlParameters));
        }
        private List<Supervisors> ReadTables(DataTable dataTable)
        {
            List<Supervisors> activities = new List<Supervisors>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Supervisors super = new Supervisors()
                {
                    Supervisor_ID = (int)dr["Supervisor_ID"],
                    FirstName = (String)dr["FirstName"],
                    LastName = (String)dr["LastName"]

                };
                activities.Add(super);
            }
            return activities;

        }
    }
}
