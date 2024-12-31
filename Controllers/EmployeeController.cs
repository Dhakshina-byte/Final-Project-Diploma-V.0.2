using Finalproject.Models;
using Finalproject.Services;

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
    }
}
