using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPILearning2.RequestModels;

namespace WEBAPILearning2.Repository
{
    static class StudentRepository
    {
    /// <summary>
    /// This is the post Repository method
    /// </summary>
    /// <param name="request"></param>
    /// <returns></returns>
        static public Boolean PostStudentData(Student request)
        {
            return true;

        }

        static public Student GetStudentData(int student)
        {
            return new Student
            {
                Address = "Sandton",
                Name = "Inderjeet Singh",
                Mobile = "854654646456",
                City = "D3ehli",
                DOB = DateTime.Now.AddDays(-50)
            };
        }


    }
}
