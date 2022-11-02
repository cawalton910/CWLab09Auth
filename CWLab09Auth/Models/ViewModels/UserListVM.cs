using System.ComponentModel;

namespace CWLab09Auth.Models.ViewModels
{
    public class UserListVM
    {
        public string? Email { get; set; }
        public string? Username { get; set; }
        [DisplayName("Number of roles")]
        public int NumberOfRoles { get; set; }
        [DisplayName("Role Names")]
        public string? RoleNames { get; set; }
    }
}
