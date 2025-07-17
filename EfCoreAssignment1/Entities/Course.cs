using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreAssignment1.Entities
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Duration { get; set; }
        public string Description { get; set; }
        public List<Student_Course> Students { get; set; }
        public List<courseInst> Instructors { get; set; }
        public int Top_Id { get; set; }
        public Topic Topic { get; set; }
    }
}
