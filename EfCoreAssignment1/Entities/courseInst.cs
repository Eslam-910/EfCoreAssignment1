using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EfCoreAssignment1.Entities
{
    internal class courseInst
    {
        
        public int InstructorId { get; set; }
        public int CourseId { get; set; }
        public string Evaluate { get; set; }
    }
}
