using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using myAbp.Configuration;
using myAbp.Web;

namespace myAbp.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class myAbpDbContextFactory : IDesignTimeDbContextFactory<myAbpDbContext>
    {
        public myAbpDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<myAbpDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            myAbpDbContextConfigurer.Configure(builder, configuration.GetConnectionString(myAbpConsts.ConnectionStringName));

            return new myAbpDbContext(builder.Options);
        }
    }
}
