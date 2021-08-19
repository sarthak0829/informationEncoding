using Api.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using System;

namespace Api.Controllers
{
    #region StudentController
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private List<Student> students = new List<Student>()
            {
                new Student{StudentId =1, Firstname = "SARTHAK", Lastname="ALANG", UserName="sarthak", Password ="123456"},
                new Student{StudentId =2, Firstname = "ARUN", Lastname="KUMAR", UserName="arun", Password ="123456"},
                new Student{StudentId =3, Firstname = "SHAURYA", Lastname="VINCENT", UserName="shaurya", Password ="123456"},
                new Student{StudentId =4, Firstname = "JACOB", Lastname="ORAM", UserName="jacob", Password ="123456"},
                new Student{StudentId =5, Firstname = "DAVID", Lastname="MILLER", UserName="david", Password ="123456"},
                new Student{StudentId =1, Firstname = "VIRAT", Lastname="KOHLI", UserName="virat", Password ="123456"},
                new Student{StudentId =2, Firstname = "SCOTT", Lastname="STYRIS", UserName="scott", Password ="123456"},
                new Student{StudentId =3, Firstname = "ADAM", Lastname="GILCHRIST", UserName="adam", Password ="123456"},
                new Student{StudentId =4, Firstname = "ABDUL", Lastname="RASHID", UserName="abdul", Password ="123456"},
                new Student{StudentId =5, Firstname = "CHRIS", Lastname="DYCK", UserName="chris", Password ="123456"}

            };

        // GET: api/AllStudents

        // GET: api/Student
        [HttpGet]
        [Authorize]
        public List<Student> Get()
        {
            return students;
        }

        // GET: api/Student/5
        [Authorize]
        [HttpGet("{id}", Name = "Get")]
        public Student Get(int id)
        {
            Student s = null;
            students.ForEach(delegate (Student student)
            {
                if (student.StudentId == id)
                {
                    s = student;
                }
            });
            return s;
        }
    }
}
#endregion
