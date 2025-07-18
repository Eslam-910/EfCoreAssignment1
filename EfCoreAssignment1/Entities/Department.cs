﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace EfCoreAssignment1.Entities
{
    //This Class Use Way Conversion Mapping
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Student> Students { get; set; }
        public DateTime HirringDate { get; set; }
        public int Ins_Id { get; set; }
        public List<Instructor> Instructor { get; set; }
    }
}
