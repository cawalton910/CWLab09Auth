using Microsoft.AspNetCore.Identity;

namespace CWLab09Auth.Services
{
    public interface IRoleRepository
    {
        IQueryable<IdentityRole> ReadAll();
    }
}
