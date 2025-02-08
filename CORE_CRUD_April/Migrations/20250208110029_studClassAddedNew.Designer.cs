﻿// <auto-generated />
using CORE_CRUD_April.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CORE_CRUD_April.Migrations
{
    [DbContext(typeof(MyEmpDBcontext))]
    [Migration("20250208110029_studClassAddedNew")]
    partial class studClassAddedNew
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CORE_CRUD_April.Models.Department", b =>
                {
                    b.Property<int>("DeptID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DeptID"));

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DeptID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("CORE_CRUD_April.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeptID")
                        .HasColumnType("int");

                    b.Property<string>("Salary")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("name")
                        .IsRequired()
                        .HasColumnType("varchar(100)")
                        .HasColumnName("EmpName");

                    b.HasKey("Id");

                    b.HasIndex("DeptID");

                    b.ToTable("Employees");
                });

            modelBuilder.Entity("CORE_CRUD_April.Models.Employee", b =>
                {
                    b.HasOne("CORE_CRUD_April.Models.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DeptID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });
#pragma warning restore 612, 618
        }
    }
}
