using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using myAbp.Authorization.Roles;
using myAbp.Authorization.Users;
using myAbp.MultiTenancy;
using myAbp.Core;

namespace myAbp.EntityFrameworkCore
{
    public class myAbpDbContext : AbpZeroDbContext<Tenant, Role, User, myAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Baby> Babys { get; set; }
        public DbSet<PlayerProfession> PlayerProfessions { get; set; }

        public DbSet<Family> Families { get; set; }

        public myAbpDbContext(DbContextOptions<myAbpDbContext> options)
            : base(options)
        {

        }
    }
}
