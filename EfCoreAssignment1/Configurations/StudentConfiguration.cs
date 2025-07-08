using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreAssignment1.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.Extensions.Options;

namespace EfCoreAssignment1.Configurations
{
    internal class StudentConfiguration:IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> S)
        {
            S.HasKey(s => s.Id);
            S.Property(s => s.FName).HasMaxLength(50).IsRequired();
            S.Property(s => s.LName).HasMaxLength(50).IsRequired();
            S.Property(s => s.Age).IsRequired(false).HasColumnName("Student Age");
            S.Property(s => s.Address)
            .IsRequired(false)
            .HasMaxLength(100)
            .HasColumnName("Student Addresses");
            
        }

        
    }
}
