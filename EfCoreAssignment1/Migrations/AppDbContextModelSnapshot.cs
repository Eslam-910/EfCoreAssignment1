﻿// <auto-generated />
using System;
using EfCoreAssignment1.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EfCoreAssignment1.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.13")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("EfCoreAssignment1.Entities.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Duration")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Top_Id")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("Top_Id");

                    b.ToTable("Courses", (string)null);
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Department", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("HirringDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ins_Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departments", (string)null);
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Instructor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Bonus")
                        .HasColumnType("float");

                    b.Property<int>("D_Id")
                        .HasColumnType("int");

                    b.Property<int>("HourRate")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Salary")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.HasIndex("D_Id");

                    b.ToTable("Instructors", (string)null);
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)")
                        .HasColumnName("Student Addresses");

                    b.Property<int?>("Age")
                        .HasColumnType("int")
                        .HasColumnName("Student Age");

                    b.Property<int>("D_Id")
                        .HasColumnType("int");

                    b.Property<string>("FName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("LName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.HasIndex("D_Id");

                    b.ToTable("Students", (string)null);
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Student_Course", b =>
                {
                    b.Property<int>("StudentId")
                        .HasColumnType("int");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<double>("Grad")
                        .HasColumnType("float");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("Student_Courses", (string)null);
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Topic", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Topics", (string)null);
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.courseInst", b =>
                {
                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<int>("InstructorId")
                        .HasColumnType("int");

                    b.Property<string>("Evaluate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CourseId", "InstructorId");

                    b.HasIndex("InstructorId");

                    b.ToTable("CourseInstructor", (string)null);
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Course", b =>
                {
                    b.HasOne("EfCoreAssignment1.Entities.Topic", "Topic")
                        .WithMany("Courses")
                        .HasForeignKey("Top_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Topic");
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Instructor", b =>
                {
                    b.HasOne("EfCoreAssignment1.Entities.Department", "department")
                        .WithMany("Instructor")
                        .HasForeignKey("D_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("department");
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Student", b =>
                {
                    b.HasOne("EfCoreAssignment1.Entities.Department", "Dept_Id")
                        .WithMany("Students")
                        .HasForeignKey("D_Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dept_Id");
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Student_Course", b =>
                {
                    b.HasOne("EfCoreAssignment1.Entities.Course", null)
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreAssignment1.Entities.Student", null)
                        .WithMany("Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.courseInst", b =>
                {
                    b.HasOne("EfCoreAssignment1.Entities.Course", null)
                        .WithMany("Instructors")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EfCoreAssignment1.Entities.Instructor", null)
                        .WithMany("Courses")
                        .HasForeignKey("InstructorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Course", b =>
                {
                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Department", b =>
                {
                    b.Navigation("Instructor");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Instructor", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Student", b =>
                {
                    b.Navigation("Courses");
                });

            modelBuilder.Entity("EfCoreAssignment1.Entities.Topic", b =>
                {
                    b.Navigation("Courses");
                });
#pragma warning restore 612, 618
        }
    }
}
