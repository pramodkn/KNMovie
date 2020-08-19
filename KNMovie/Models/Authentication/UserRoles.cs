using Microsoft.AspNetCore.Identity;
using System;

namespace KNMovie.Models.Authentication
{
    public static class UserRoles
    {
        public const string Admin = "Admin";
        public const string Customer = "Customer";
    }
    public class Role : IdentityRole<Guid>
    { }
    public class ApplicationRole
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public string NormalizedName { get; set; }
    }
    public class ExtendedIdentityRole : IdentityRole<string>
    {
        public ExtendedIdentityRole() { }

        public string Description { get; set; }
    }


}
