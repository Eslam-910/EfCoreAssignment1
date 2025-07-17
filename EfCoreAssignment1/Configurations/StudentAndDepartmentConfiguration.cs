using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using EfCoreAssignment1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EfCoreAssignment1.Configurations
{
    internal class StudentAndDepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.HasMany(D => D.Students)
            .WithOne(S => S.Dept_Id).HasForeignKey(S => S.D_Id);
        }
    }
}
