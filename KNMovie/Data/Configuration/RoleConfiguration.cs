using KNMovie.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace KNMovie.Data.Configuration
{
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        private const string adminId = "2301D884-221A-4E7D-B509-0113DCC043E1";
        private const string userId = "01B168FE-810B-432D-9010-233BA0B380E9";

        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {

            builder.HasData(
                    new IdentityRole
                    {
                        Id = adminId,
                        Name = UserRoles.Admin,
                        NormalizedName = UserRoles.Admin
                    },
                    new IdentityRole
                    {
                        Id = userId,
                        Name = UserRoles.Customer,
                        NormalizedName = UserRoles.Customer
                    }
                );
        }
    }
}
