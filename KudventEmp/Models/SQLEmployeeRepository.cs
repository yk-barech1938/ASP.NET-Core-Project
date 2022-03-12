using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KudventEmp.Models
{
    public class SQLEmployeeRepository : IEmployeeRepository
    {
        private readonly AppDbContext context;
        private readonly ILogger<SQLEmployeeRepository> logger;

        public SQLEmployeeRepository(AppDbContext context, ILogger<SQLEmployeeRepository> logger )
        {
            this.context = context;
            this.logger = logger;
        }
        public Employee Add(Employee employee)
        {
            context.Employees.Add(employee);
            context.SaveChanges();
            return employee;
        }

        public Employee Delete(int id)
        {
            Employee employee = context.Employees.Find(id);
            if (employee!=null)
            {
                context.Employees.Remove(employee);
                context.SaveChanges();
            }

            return employee;

        }

        public IEnumerable<Employee> GetAllEmployee()
        {
            return context.Employees;
        }

        public Employee GetEmployee(int Id)
        {
            this.logger.LogTrace("Trace Log");
            this.logger.LogDebug("Debug Log");
            this.logger.LogInformation("Information Log");
            this.logger.LogWarning("Warning Log");
            this.logger.LogError("Error Log");
            this.logger.LogCritical("Critical Log");
            return context.Employees.Find(Id);
        }

        public Employee Update(Employee employeeChanges)
        {
            var employee = context.Employees.Attach(employeeChanges);
            employee.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return employeeChanges;
        }
    }
}
