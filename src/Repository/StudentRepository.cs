using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WEBAPILearning2.RequestModels;
using WEBAPILearning2.Models;

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
             studentDBContext studentDBContext  = new studentDBContext();
            StudentDetails DBStudent = new StudentDetails();
            DBStudent.Name = request.Name;
            DBStudent.Address = request.Address;
            DBStudent.City = request.City;
            DBStudent.Mobile =request.Mobile;
            DBStudent.Dob = request.DOB;
            DBStudent.Gender = request.gender;
            DBStudent.Studentid = request.studentid;
            DBStudent.Fathername = "Father-asdfsadasd";

            studentDBContext.StudentDetails.Add(DBStudent);
            studentDBContext.SaveChanges();

            return true;
        }
        static public Student GetStudentData(int student)
        {
            studentDBContext studentDBContext = new studentDBContext();
            StudentDetails DBStudent = new StudentDetails();

            Student StudentResponse = new Student();

            var data = studentDBContext.StudentDetails.Where(a => a.Studentid == student).Single();

            StudentResponse.studentid = data.Studentid;
            StudentResponse.Name = data.Name;
            StudentResponse.Address = data.Address;
            StudentResponse.City = data.City;
            StudentResponse.DOB = data.Dob;
            StudentResponse.Mobile = data.Mobile;

            return StudentResponse;
        }


    }
}
