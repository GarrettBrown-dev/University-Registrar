﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniReg.Models;

namespace UniReg.Migrations
{
    [DbContext(typeof(UniRegContext))]
    [Migration("20210105193428_DepCour")]
    partial class DepCour
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.4-servicing-10062")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("UniReg.Models.Course", b =>
                {
                    b.Property<int>("CourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("CourseId");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("UniReg.Models.CourseStudent", b =>
                {
                    b.Property<int>("CourseStudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<int>("StudentId");

                    b.HasKey("CourseStudentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("StudentId");

                    b.ToTable("CourseStudent");
                });

            modelBuilder.Entity("UniReg.Models.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("DepartmentId");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("UniReg.Models.DepartmentCourse", b =>
                {
                    b.Property<int>("DepartmentCourseId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<int>("DepartmentId");

                    b.HasKey("DepartmentCourseId");

                    b.HasIndex("CourseId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("DepartmentCourse");
                });

            modelBuilder.Entity("UniReg.Models.DepartmentCourseStudent", b =>
                {
                    b.Property<int>("DepartmentCourseStudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("CourseId");

                    b.Property<int>("CourseStudentId");

                    b.Property<int>("DepartmentId");

                    b.Property<int>("StudentId");

                    b.HasKey("DepartmentCourseStudentId");

                    b.HasIndex("CourseId");

                    b.HasIndex("DepartmentId");

                    b.HasIndex("StudentId");

                    b.ToTable("DepartmentCourseStudent");
                });

            modelBuilder.Entity("UniReg.Models.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("StudentId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UniReg.Models.CourseStudent", b =>
                {
                    b.HasOne("UniReg.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniReg.Models.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniReg.Models.DepartmentCourse", b =>
                {
                    b.HasOne("UniReg.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniReg.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("UniReg.Models.DepartmentCourseStudent", b =>
                {
                    b.HasOne("UniReg.Models.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniReg.Models.Department", "Department")
                        .WithMany("Courses")
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("UniReg.Models.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
