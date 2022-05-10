namespace BaiThiEAD.Migrations
{
    using BaiThiEAD.Models;
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<BaiThiEAD.Data.EmployeeManager>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BaiThiEAD.Data.EmployeeManager context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.

            var employees = new List<Employee>
            {
            new Employee{Name="Phương", Salary=10000000, Department="Kế toán"},
            new Employee{Name="Hinh", Salary=20000000, Department="Tài chính"},
            new Employee{Name="Quân", Salary=30000000, Department="Nhân sự"},
            new Employee{Name="Thuận", Salary=40000000, Department="Phát triển sản phẩm"},
            new Employee{Name="Tuấn", Salary=50000000, Department="Hành Chính"},
            new Employee{Name="Bách", Salary=60000000, Department="Thiết kế"},
            new Employee{Name="Hùng", Salary=70000000, Department="Đào tạo"},
            new Employee{Name="Luyến", Salary=80000000, Department="Doanh nghiệp"},
            new Employee{Name="Khánh", Salary=90000000, Department="Phát triển sản phẩm"},
            new Employee{Name="Thắng", Salary=100000000, Department="Tài chính"},

            };

            employees.ForEach(s => context.Employees.Add(s));
            context.SaveChanges();
        }
    }
}
