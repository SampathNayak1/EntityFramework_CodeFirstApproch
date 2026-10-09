using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EntityFramework_CodeFirstApproch.Models
{
    public class EmployeeDbContext:DbContext
    {
        public EmployeeDbContext() : base("DBCS") { }

        public DbSet<Employee> employees { get; set; }
    }
}