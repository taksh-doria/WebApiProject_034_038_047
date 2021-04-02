using RestApiStudentManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiStudentManagement.Data
{
    public class StudentRepo : IStudentRepo
    {
        private readonly StudentAppContext context;

        public StudentRepo(StudentAppContext context)
        {
            this.context = context;
        }
        public void addStudent(Student Student)
        {
            context.Students.Add(Student);
            context.SaveChanges();
            return;
            //throw new NotImplementedException();
        }

        public bool deleteStudent(int id)
        {
            var deleteItm =  context.Students.Find(id);
            if(deleteItm == null)
            {
                return false;
            }
            else
            {
                context.Students.Remove(deleteItm);
                context.SaveChanges();
                return true;
            }

           // throw new NotImplementedException();
        }

        public IEnumerable<Student> getAllStudents()
        {
            return context.Students;
            //throw new NotImplementedException();
        }

        public Student getStudent(int id)
        {
            var prod = context.Students.Find(id);
            if(prod == null)
            {
                return null; 
            }
            else
            {
                return prod;
            }
            //throw new NotImplementedException();
        }

        public void updateStudent(Student Student)
        {
            var t = context.Students.Attach(Student);
            t.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return ;
            //throw new NotImplementedException();
        }
    }
}
