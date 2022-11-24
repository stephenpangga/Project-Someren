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
    public class Activities_DAO : Base
    {
        //stephen's part

        //to display all the activities
        //this querry to get the genaral information from the database
        public List<Activity> Db_Get_All_Activity()
        {
            string query = "SELECT [Activity Id], Description, NumberOfStudent, NumberOfSupervisor " +
                            "FROM Activities";

            SqlParameter[] sqlParameters = new SqlParameter[0];

            return ReadTable(ExecuteSelectQuery(query, sqlParameters));
        }

        private List<Activity> ReadTable(DataTable dataTable)
        {
            List<Activity> activities = new List<Activity>();

            foreach (DataRow dr in dataTable.Rows)
            {
                Activity activity = new Activity()
                {
                    ID = (int)(dr["Activity Id"]),
                    Description = (String)(dr["Description"].ToString()),
                    numbOfStudent = (int)(dr["NumberOfStudent"]),
                    numbOfTeacher = (int)(dr["NumberOfSupervisor"]),
                };
                activities.Add(activity);
            }
            return activities;
        }
        
        //Insert Activities
        public void AddActivity(string Name,int numberofStud,int numberofSupervisor)//need to add parameters
        {
            string Addquery = "INSERT INTO Activities VALUES('"+Name+"','"+numberofStud+"','"+numberofSupervisor+"' )";
            //insert [table]
            //VALUE (THE STUFF)
            SqlParameter[] sqlParametersAdd = new SqlParameter[0];

            ExecuteEditQuery(Addquery, sqlParametersAdd);

            //use edit querry
        }
        
        //Delete Activities
        public void DeleteActivity(int id)//need to add parameters
        {
            string Delquery = "DELETE FROM Activities WHERE [Activity Id]=" + id;

            SqlParameter[] sqlParametersDel = new SqlParameter[0];

            ExecuteEditQuery(Delquery, sqlParametersDel);
            //use edit querry
        }
        //Update Activities
        public void UpdateActivity(int id,string Name, int numberofStud, int numberofSupervisor)//need to add parameters
        {
            string Updquery = $"UPDATE Activities SET Description= '{Name}', NumberofStudent= {numberofStud}," +
                              $" NumberOfSupervisor= {numberofSupervisor} WHERE [Activity Id] ={id}";
            //Update [table]
            //SET which info.
            //WHERE [table]
            SqlParameter[] sqlParametersUpdate = new SqlParameter[0];

            ExecuteEditQuery(Updquery, sqlParametersUpdate);
            //use edit querry
        }
        //public bool IsExist(string name)
        //{
        //    string querrycheck = $"SELECT * FROM Activities WHERE Description = {name}";
        //    SqlParameter[] sqlParametersDel = new SqlParameter[0];
        //    DataTable dataTable = ExecuteSelectQuery(querrycheck, sqlParametersDel);

        //    //if(dataTable.Rows.Count==0)
        //    //{
        //    //    return false;
        //    //}
        //    //else
        //    //{
        //    //    return true;
        //    //}
        //}
    }
}
