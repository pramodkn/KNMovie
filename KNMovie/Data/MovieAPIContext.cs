using KNMovie.Data.Configuration;
using KNMovie.Models;
using KNMovie.Models.Authentication;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace KNMovie.Data
{
    public class MovieAPIContext : IdentityDbContext<ApplicationUser>
    {
        public MovieAPIContext(DbContextOptions<MovieAPIContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new RoleConfiguration());
            builder.ApplyConfiguration(new AdminConfiguration());
            builder.ApplyConfiguration(new UsersWithRolesConfig());
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Auditorium> Auditorium { get; set; }

        public DbSet<AuditoriumScreen> AuditoriumScreen { get; set; }

        public DbSet<City> City { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Multiplex> Multiplex { get; set; }
        public DbSet<Reservation> Reservation { get; set; }

        public DbSet<Screening> Screening { get; set; }





    }
}
