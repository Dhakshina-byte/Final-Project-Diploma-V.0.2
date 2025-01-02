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
        private readonly EmployeeService employeeService;

        public EmployeeController()
        {
            employeeService = new EmployeeService();
        }

        public void AddEmployee(Employee employee,Role role, Department department)
        {
            employeeService.AddEmployee(employee, role, department);
        }
        public void AddLogine(Employee employee, Login login)
        {
            employeeService.AddLogine(employee, login);
        }

        public DataTable getEmployee()
        {
            return employeeService.getemployee();
        }
        public DataTable getaccountant()
        {
            return employeeService.getAccountant();
        }
        public DataTable getSalesDirector() 
        {
            return employeeService.getSalesDirector();
        }

        public DataTable getInventoryManager()
        {
            return employeeService.getInventoryManager();
        }

        public DataTable getServiceHead()
        {
            return employeeService.getServiceHead();
        }
        public void DeleteEmployee(int EID)
        {
            employeeService.DeleteEmployee(EID);
        }
        public int getthelastemp()
        {
            return employeeService.getthelastemp();
        }

        public void UpdateEmployee(Employee employee,int EID)
        {
            employeeService.UpdateEmployee(employee,EID);
        }
        public DataTable searchEmployee(string search)
        {
           return employeeService.getEmployeeBysearch(search);
        }
    }
}
