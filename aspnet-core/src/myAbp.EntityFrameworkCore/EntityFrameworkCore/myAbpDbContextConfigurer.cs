using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace myAbp.EntityFrameworkCore
{
    public static class myAbpDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<myAbpDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<myAbpDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
