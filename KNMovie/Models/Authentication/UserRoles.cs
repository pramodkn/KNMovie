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
}
