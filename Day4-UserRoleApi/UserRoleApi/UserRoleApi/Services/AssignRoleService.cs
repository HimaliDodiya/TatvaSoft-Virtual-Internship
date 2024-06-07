using System.Collections.Generic;
using UserRoleApi.Models;
using UserRoleApi.Repositories;

namespace UserRoleApi.Services
{
    public class AssignRoleService : IAssignRoleService
    {
        private readonly IUserRoleAssignmentRepository _userRoleAssignmentRepository;

        public AssignRoleService(IUserRoleAssignmentRepository userRoleAssignmentRepository)
        {
            _userRoleAssignmentRepository = userRoleAssignmentRepository;
        }

        public List<UserRoleAssignment> GetAllAssignments()
        {
            return _userRoleAssignmentRepository.GetAllAssignments();
        }

        public UserRoleAssignment GetAssignmentById(int id)
        {
            return _userRoleAssignmentRepository.GetAssignmentById(id);
        }

        public void AssignRole(UserRoleAssignment assignment)
        {
            _userRoleAssignmentRepository.AssignRole(assignment);
        }

        public void UpdateAssignment(UserRoleAssignment assignment)
        {
            _userRoleAssignmentRepository.UpdateAssignment(assignment);
        }

        public void RemoveAssignment(int userId, int roleId)
        {
            _userRoleAssignmentRepository.RemoveAssignment(userId, roleId);
        }
    }
}
