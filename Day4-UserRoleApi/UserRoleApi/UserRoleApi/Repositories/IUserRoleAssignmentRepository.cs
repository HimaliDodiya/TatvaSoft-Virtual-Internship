using System.Collections.Generic;
using UserRoleApi.Models;

namespace UserRoleApi.Repositories
{
    public interface IUserRoleAssignmentRepository
    {
        List<UserRoleAssignment> GetAllAssignments();
        UserRoleAssignment GetAssignmentById(int id); // Change to single id parameter
        void AssignRole(UserRoleAssignment assignment);
        void UpdateAssignment(UserRoleAssignment assignment);
        void RemoveAssignment(int userId, int roleId);
    }
}
