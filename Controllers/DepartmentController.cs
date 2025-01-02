//using System.Collections.Generic;
//using Finalproject.Models;
//using Finalproject.Services;

//namespace Finalproject.Controllers
//{
//    public class DepartmentController
//    {
//        private readonly DepartmentService _departmentService;

//        public DepartmentController()
//        {
//            _departmentService = new DepartmentService();
//        }

//        public List<Department> GetDepartments()
//        {
//            return _departmentService.GetAllDepartments();
//        }

//        public bool AddDepartment(string name, string location)
//        {
//            return _departmentService.AddDepartment(name, location);
//        }

//        public bool DeleteDepartment(int departmentId)
//        {
//            return _departmentService.DeleteDepartment(departmentId);
//        }
//    }
//}
