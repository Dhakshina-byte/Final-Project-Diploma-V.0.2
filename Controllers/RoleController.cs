using System.Collections.Generic;
using Finalproject.Models;
using Finalproject.Services;

namespace Finalproject.Controllers
{
    public class RoleController
    {
        private readonly RoleService _roleService;

        public RoleController()
        {
            _roleService = new RoleService();
        }

        public List<Role> GetRoles()
        {
            return _roleService.GetAllRoles();
        }

        public bool AddRole(string roleName)
        {
            return _roleService.AddRole(roleName);
        }

        public bool DeleteRole(int roleId)
        {
            return _roleService.DeleteRole(roleId);
        }
    }
}
