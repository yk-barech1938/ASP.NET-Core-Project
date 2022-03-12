using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KudventEmp.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 1,
                    Name = "YK Barech",
                    Department = Dept.IT,
                    Email = "ykbarechh@gmail.com"
                },
                new Employee
                {
                    Id = 2,
                    Name = "alpha",
                    Department = Dept.HR,
                    Email = "alpha@gmail.com"
                }

                );

        }
    }
}
