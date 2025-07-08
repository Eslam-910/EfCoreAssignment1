using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace EfCoreAssignment1.Entities
{
    internal class Stud_Course
    {
        //  [ForeignKey("Stud_Id")]
        
        public int Stud_Id { get; set; }
       // [ForeignKey("Course_Id")]
        public Course Course_Id { get; set; }
        public int Grad { get; set; }
    }
}
