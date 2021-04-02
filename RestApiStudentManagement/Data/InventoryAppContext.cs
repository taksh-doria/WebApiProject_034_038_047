using Microsoft.EntityFrameworkCore;
using RestApiStudentManagement.model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiStudentManagement.Data
{
    public class StudentAppContext : DbContext
    {
        public StudentAppContext(DbContextOptions<StudentAppContext> options)
            : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
