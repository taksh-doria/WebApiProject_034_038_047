using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RestApiStudentManagement.Data;
using RestApiStudentManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiStudentManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentRepo repo;
        public StudentController(IStudentRepo repo)
        {
            this.repo = repo;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Student>> getAllStudents() {
            var temp = repo.getAllStudents();
            //foreach (Student s in temp)
            //{
              //  Console.WriteLine(s.StudentId + " ");
            //}
            return Ok(temp);

        }

        [HttpGet("{id}")] 
        public ActionResult<Student> getStudent(int id)
        {
            var temp = repo.getStudent(id);
            return Ok(temp);           

        }

        [HttpPost]
        public ActionResult addStudent(Student Student)
        {
            Student temp = new Student();
            temp.branch = Student.branch;
            temp.name = Student.name;
            temp.cpi = Student.cpi;
            temp.rollnum = Student.rollnum;
            repo.addStudent(temp);
            return Ok();
        }
        [HttpDelete("{id}")]
        
        public ActionResult deleteStudent(int id)
        {
            var temp = repo.deleteStudent(id);
            if(temp == false)
            {
                return NotFound();
            }
            else
            {
                return Ok();
            }
            

        }

        [HttpPut("{id}")]
        public ActionResult updateStudent(int id, Student Student)
        {
            Console.WriteLine("from updateStudent:"+id);
            Student temp = repo.getStudent(id);
            temp.branch = Student.branch;
            temp.name = Student.name;
            temp.cpi = Student.cpi;
            temp.rollnum = Student.rollnum;
            temp.StudentId = Student.StudentId;
            repo.updateStudent(temp);

            return Ok();
        }

    }
}
