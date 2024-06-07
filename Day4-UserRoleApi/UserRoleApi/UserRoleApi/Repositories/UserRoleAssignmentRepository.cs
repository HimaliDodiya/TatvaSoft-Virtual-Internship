using System.Collections.Generic;
using System.Linq;
using UserRoleApi.Data;
using UserRoleApi.Models;

namespace UserRoleApi.Repositories
{
    public class UserRoleAssignmentRepository : IUserRoleAssignmentRepository
    {
        private readonly AppDbContext _context;

        public UserRoleAssignmentRepository(AppDbContext context)
        {
            _context = context;
        }

        public List<UserRoleAssignment> GetAllAssignments()
        {
            return _context.UserRoleAssignments.ToList();
        }

        public UserRoleAssignment GetAssignmentById(int id)
        {
            return _context.UserRoleAssignments.FirstOrDefault(a => a.Id == id);
        }

        public void AssignRole(UserRoleAssignment assignment)
        {
            var user = _context.Users.FirstOrDefault(u => u.UserId == assignment.UserId);
            var role = _context.Roles.FirstOrDefault(r => r.RoleId == assignment.RoleId);

            if (user == null || role == null)
            {
                throw new KeyNotFoundException("User or Role not found");
            }

            assignment.UserName = user.UserName;
            assignment.RoleName = role.RoleName;

            _context.UserRoleAssignments.Add(assignment);
            _context.SaveChanges();
        }

        public void UpdateAssignment(UserRoleAssignment assignment)
        {
            var existingAssignment = _context.UserRoleAssignments.FirstOrDefault(a => a.Id == assignment.Id);
            if (existingAssignment != null)
            {
                existingAssignment.UserId = assignment.UserId;
                existingAssignment.UserName = _context.Users.FirstOrDefault(u => u.UserId == assignment.UserId)?.UserName;
                existingAssignment.RoleId = assignment.RoleId;
                existingAssignment.RoleName = _context.Roles.FirstOrDefault(r => r.RoleId == assignment.RoleId)?.RoleName;

                _context.UserRoleAssignments.Update(existingAssignment);
                _context.SaveChanges();
            }
        }

        public void RemoveAssignment(int userId, int roleId)
        {
            var assignment = _context.UserRoleAssignments.FirstOrDefault(a => a.UserId == userId && a.RoleId == roleId);
            if (assignment != null)
            {
                _context.UserRoleAssignments.Remove(assignment);
                _context.SaveChanges();
            }
        }
    }
}
