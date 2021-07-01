using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CoreApp.Models;

namespace CoreApp.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser> // Point to Custom Identity User Model
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        /// <summary>
        /// Override the EFF Table/schema Builder parameters
        /// </summary>
        /// <param name="builder"></param>
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Set a custom schema name to all tables
            builder.HasDefaultSchema("CoreApp");

            // Map each Identity object to its custom table names
            builder.Entity<ApplicationUser>(entity => entity.ToTable("User"));
            builder.Entity<IdentityRole>(entity => entity.ToTable("Role"));
            builder.Entity<IdentityUserRole<string>>(entity => entity.ToTable("UserRoles"));
            builder.Entity<IdentityUserClaim<string>>(entity => entity.ToTable("UserClaims"));
            builder.Entity<IdentityUserLogin<string>>(entity => entity.ToTable("UserLogins"));
            builder.Entity<IdentityRoleClaim<string>>(entity => entity.ToTable("RoleClaims"));
            builder.Entity<IdentityUserToken<string>>(entity => entity.ToTable("UserTokens"));
        }
    }
}
