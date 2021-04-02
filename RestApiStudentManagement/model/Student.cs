using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace RestApiStudentManagement.model
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }
        [Required]
        public int rollnum  { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public double cpi { get; set; }
        [Required]
        public string branch { get; set; }
        
    }
}
