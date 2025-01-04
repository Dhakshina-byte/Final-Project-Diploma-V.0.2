using Finalproject.Models;
using Finalproject.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Finalproject.Controllers
{
    public class EmployeeController
    {
        // EmployeeService instance to handle employee-related operations
        private readonly EmployeeService employeeService;

        // Constructor to initialize EmployeeService
        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }

        // Method to add a new employee along with their role and department
        public void AddEmployee(Employee employee, Role role, Department department)
        {
            employeeService.AddEmployee(employee, role, department);
        }

        // Method to add login details for an employee
        public void AddLogine(Employee employee, Login login)
        {
            employeeService.AddLogine(employee, login);
        }

        // Method to get all employees
        public DataTable getEmployee()
        {
            return employeeService.getemployee();
        }

        // Method to get all accountants
        public DataTable getaccountant()
        {
            return employeeService.getAccountant();
        }

        // Method to get all sales directors
        public DataTable getSalesDirector()
        {
            return employeeService.getSalesDirector();
        }

        // Method to get all inventory managers
        public DataTable getInventoryManager()
        {
            return employeeService.getInventoryManager();
        }

        // Method to get all service heads
        public DataTable getServiceHead()
        {
            return employeeService.getServiceHead();
        }

        // Method to delete an employee by their ID
        public void DeleteEmployee(int EID)
        {
            employeeService.DeleteEmployee(EID);
        }

        // Method to get the last employee ID
        public int getthelastemp()
        {
            return employeeService.getthelastemp();
        }

        // Method to update an employee's details by their ID
        public void UpdateEmployee(Employee employee, int EID)
        {
            employeeService.UpdateEmployee(employee, EID);
        }

        // Method to search for employees based on a search string
        public DataTable searchEmployee(string search)
        {
            return employeeService.getEmployeeBysearch(search);
        }
    }
}
