using System.Collections.Generic;
using UserRoleApi.Models;

namespace UserRoleApi.Services
{
    public interface IAssignRoleService
    {
        List<UserRoleAssignment> GetAllAssignments();
        UserRoleAssignment GetAssignmentById(int id); // Ensure it matches the repository interface
        void AssignRole(UserRoleAssignment assignment);
        void UpdateAssignment(UserRoleAssignment assignment);
        void RemoveAssignment(int userId, int roleId);
    }
}
