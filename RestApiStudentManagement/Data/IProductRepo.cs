using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using RestApiStudentManagement.model;

namespace RestApiStudentManagement.Data
{
    public interface IStudentRepo
    {
        public void addStudent(Student Student  );
        public bool deleteStudent(int id);
        public void updateStudent(Student Student);
        public IEnumerable<Student> getAllStudents();
        public Student getStudent(int id);
    }
}
