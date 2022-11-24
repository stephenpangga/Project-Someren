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
    public class Teacher_Service
    {
        Teacher_DAO teacher_db = new Teacher_DAO();

        public List<Teacher> GetTeachers()
        {
            //List<Teacher> teacher = teacher_db.Db_Get_All_Teachers();
            //return teacher;
            
            try
            {
                List<Teacher> teacher = teacher_db.Db_Get_All_Teachers();
                return teacher;
            }
            catch (Exception)
            {
                /*
                // something went wrong connecting to the database, so we will add a fake student to the list to make sure the rest of the application continues working!
                List<Teacher> teacher = new List<Teacher>();
                Teacher a = new Teacher();
                a.Name = "Mr. Test Teacher";
                a.Number = 474791;
                //a.BirthDate = DateTime.Parse("1990-07-04");
                teacher.Add(a);
                Teacher b = new Teacher();
                b.Name = "Mrs. Test Teacher2";
                b.Number = 197474;
                //b.BirthDate = DateTime.Parse("2019-03-04");
                teacher.Add(b);
                return teacher;
                */
                throw new Exception("Someren couldn't connect to the database");
            }
        

        }
    }
}
