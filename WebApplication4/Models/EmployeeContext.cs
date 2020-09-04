using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Controllers;

namespace WebApplication4.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions<EmployeeContext>options):base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
