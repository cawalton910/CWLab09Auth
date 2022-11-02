using CWLab09Auth.Models.Entities;

namespace CWLab09Auth.Services
{
    public interface IUserRepository
    {
        Task<ApplicationUser?> ReadAsync(string userName);
        Task<IQueryable<ApplicationUser>> ReadAllAsync();
        Task<bool> AssignRoleAsync(string userName, string roleName);
    }
}
