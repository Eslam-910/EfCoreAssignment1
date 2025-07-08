using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreAssignment1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreAssignment1.Configurations
{
    internal class StudCoursesConfiguration : IEntityTypeConfiguration<Stud_Course>
    {
        public void Configure(EntityTypeBuilder<Stud_Course> st)
        {
            st.HasKey(st=>st.Stud_Id);
        }
    }
}
