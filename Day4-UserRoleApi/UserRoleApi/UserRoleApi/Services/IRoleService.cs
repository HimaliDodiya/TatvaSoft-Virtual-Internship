using System.Collections.Generic;
using UserRoleApi.Models;

namespace UserRoleApi.Services
{
    public interface IRoleService
    {
        List<Role> GetAllRoles();
        Role GetRoleById(int id);
        void AddRole(Role role);
        void UpdateRole(Role role);
        void DeleteRole(int id);
    }
}
