using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using myAbp.Authorization.Roles;
using myAbp.Authorization.Users;
using myAbp.MultiTenancy;

namespace myAbp.EntityFrameworkCore
{
    public class myAbpDbContext : AbpZeroDbContext<Tenant, Role, User, myAbpDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public myAbpDbContext(DbContextOptions<myAbpDbContext> options)
            : base(options)
        {
        }
    }
}
