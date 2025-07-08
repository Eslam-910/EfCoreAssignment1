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
        [Key]
        public int Inst_Id { get; set; }
        //[ForeignKey("Course_Id")]
        public int Course_Id { get; set; }
        public string Evaluate { get; set; }
    }
}
