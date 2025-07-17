using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfCoreAssignment1.Configurations;
using EfCoreAssignment1.Entities;
using Microsoft.EntityFrameworkCore;

namespace EfCoreAssignment1.Contexts
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;Database=APPG02;Trusted_Connection=True;TrustServerCertificate=True;");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudCoursesConfiguration());
            modelBuilder.ApplyConfiguration(new StudentAndDepartmentConfiguration());
            //Relationship Student With Course
            modelBuilder.Entity<Student_Course>().HasKey(SC => new {SC.StudentId,SC.CourseId});

           //Relationship DepartmentWithInstructor
            modelBuilder.Entity<Department>().HasMany(D => D.Instructor)
                .WithOne(I=>I.department)
                .HasForeignKey(I=>I.D_Id);

            //Relationship Course With Instructor
            modelBuilder.Entity<courseInst>().HasKey(CI => new {CI.CourseId,CI.InstructorId});

            // The Relationship Between Topic And Course
            modelBuilder.Entity<Topic>().HasMany(T=>T.Courses)
                .WithOne(C=>C.Topic)
                .HasForeignKey(T=>T.Top_Id);
                
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Student_Course> Student_Courses { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Topic> Topics { get; set; }
        public DbSet<Instructor> Instructors { get; set; }
        public DbSet<Course> Courses { get; set; }
        public DbSet<courseInst> CourseInstructor { get; set; }

    }
}
