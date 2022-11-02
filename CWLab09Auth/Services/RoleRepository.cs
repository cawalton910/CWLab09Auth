using Microsoft.AspNetCore.Identity;

namespace CWLab09Auth.Services
{
    public class RoleRepository : IRoleRepository
    {
        private readonly ApplicationDbContext _db;
        public RoleRepository(ApplicationDbContext db)
        {
            _db = db;
        }
        public IQueryable<IdentityRole> ReadAll()
        {
            return _db.Roles;
        }
    }
}
