using BaiThiEAD.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BaiThiEAD.Data
{
    public class EmployeeManager : DbContext
    {
        public EmployeeManager(): base("EmployeeManager") { }

        public DbSet<Employee> Employees { get; set; }
    }
}