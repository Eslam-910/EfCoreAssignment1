using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EfCoreAssignment1.Entities
{
    internal class Student_Course
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public double Grad { get; set; }
    }
}
