﻿using Microsoft.EntityFrameworkCore;

namespace CORE_CRUD_April.Models
{
    public class MyEmpDBcontext:DbContext
    {
        public MyEmpDBcontext(DbContextOptions<MyEmpDBcontext> options):base(options)
        {
                
        }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Student> Studenttbl { get; set; }
    }
}
