using ConsoleAppFramework.Model;                            
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppFramework.DataAccess
{
    public class AppContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Server=SIMARA-MAHARRAM;Database=EmployeeDb;Integrated Security=true;");
        }
        public DbSet<Employee> Employees { get; set; }
    }
}
