using CWLab09Auth.Models.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace CWLab09Auth.Services
{
    public class UserRepository : IUserRepository
    {
        private readonly ApplicationDbContext _db;
        private readonly UserManager<ApplicationUser> _userManager;

        public UserRepository(ApplicationDbContext db, UserManager<ApplicationUser> userManager)
        {
            _db = db;
            _userManager = userManager;
        }

        public async Task<bool> AssignRoleAsync(string userName, string roleName)
        {
            var user = await ReadAsync(userName);
            if (user != null)
            {
                await _userManager.AddToRoleAsync(user, roleName);
                return true;
            }
            return false;
        }

        public async Task<IQueryable<ApplicationUser>> ReadAllAsync()
        {
            var users = _db.Users;
            
            foreach (var user in users)
            {
                user.Roles = await _userManager.GetRolesAsync(user);
            }
            return users;
        }

        public async Task<ApplicationUser?> ReadAsync(string userName)
        {
            var user = await _db.Users.FirstOrDefaultAsync(u => u.UserName ==
            userName);
            if (user != null)
            {
                user.Roles = await _userManager.GetRolesAsync(user);
            }
            return user;
        }
    }
}
