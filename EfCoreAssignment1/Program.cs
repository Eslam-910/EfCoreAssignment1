using EfCoreAssignment1.Contexts;
using EfCoreAssignment1.Entities;

namespace EfCoreAssignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AppDbContext context = new AppDbContext();
            var student = new Student()
            { 
                
                FName = "Eslam",
                LName= "Ashour",
                Age=22,
                D_Id=1,

            };
            context.Students.Add(student);
             var Depart=new Department() { HirringDate= DateTime.Now,Id=1,Name="Nework", };
            context.Departments.Add(Depart);
            var Inst = new Instructor() { Id = 1, D_Id = 1, Name = "Hossam", Salary = 500, Address = "cairo", };
            context.Instructors.Add(Inst);
            var topic = new Topic() { Id = 1, Name = "Asp.net", };
            context.Topics.Add(topic);
            var course = new Course() { Id = 1, Name = "Asp Mvc", Description = "course in Asp teachnology", Duration = 5, };
            context.Courses.Add(course);
            
            context.SaveChanges();
            

        }
    }
}
