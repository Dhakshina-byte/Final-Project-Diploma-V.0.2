using Finalproject.Models;
using Finalproject.Services;
using System.Collections.Generic;

namespace Finalproject.Controllers
{
    public class EmployeeController
    {
        private readonly EmployeeService _employeeService;

        public EmployeeController()
        {
            _employeeService = new EmployeeService();
        }

        public bool RegisterEmployee(Employee employee)
        {
            return _employeeService.RegisterEmployee(employee);
        }

        public Employee LoginEmployee(string email)
        {
            return _employeeService.LoginEmployee(email);
        }

        public bool UpdateEmployee(Employee employee)
        {
            return _employeeService.UpdateEmployee(employee);
        }

        public List<Employee> GetEmployees()
        {
            return _employeeService.GetAllEmployees();
        }

    }
}
