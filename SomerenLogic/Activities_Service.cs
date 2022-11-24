using SomerenDAL;
using SomerenModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomerenLogic
{
    public class Activities_Service
    {
        Activities_DAO activity_db = new Activities_DAO();

        //this is the basic.
        public List<Activity> GetActivity()
        {
            try
            {
                List<Activity> activity = activity_db.Db_Get_All_Activity();
                return activity;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }
        }
        
        public void AddActivity(string Name, int numberofStudent, int numberofSupervisor)
        {
            //if (!activity_db.IsExist(Name))
            //{
                
            //}
            activity_db.AddActivity(Name, numberofStudent, numberofSupervisor);//need to add parameters
        }
        
        public void DeleteActivity(int id)
        {
            activity_db.DeleteActivity(id);//need to add parameters
        }
        
        public void UpdateActivity(int id,string Name, int numberofStudent, int numberofSupervisor)
        {
            activity_db.UpdateActivity(id, Name,numberofStudent,numberofSupervisor);//need to add parameters
        }
    }
}