using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreAssignment1.Entities
{
    //This Class Use way Fluent Apis is name class Student Configuration
    internal class Student
    {
        
        public int Id { get; set; }
        public string FName { get; set; }
        public string LName { get; set; }
        public string? Address { get; set; }
        public int? Age { get; set; }
       
        public int? D_Id { get; set; }
        public Department? Dept_Id { get; set; }
        public List<Student_Course> Courses { get; set; }
    }
}
