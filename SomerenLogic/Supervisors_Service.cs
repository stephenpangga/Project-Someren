using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SomerenDAL;
using SomerenModel;

namespace SomerenLogic
{
    public class Supervisors_Service
    {
        Supervisors_DAO superdb = new Supervisors_DAO();


        public void Insert_Supervisor_Service(int supervisorid, int teacherid)
        {
            superdb.AddSupervisor(supervisorid, teacherid);
        }
        public void Delete_Supervisor_Service(int lid)
        {
            superdb.DeleteSupervisor(lid);
        }

        public List<Supervisors> GetSupervisors()
        {
            try
            {
                List<Supervisors> act = superdb.GetAllSupervisors();
                return act;
            }
            catch (Exception)
            {
                throw new Exception("Someren couldn't connect to the database");
            }

        }



    }
}
