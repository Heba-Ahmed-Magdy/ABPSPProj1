using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using ABPsinglePageProj1.Configuration;
using ABPsinglePageProj1.Web;

namespace ABPsinglePageProj1.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class ABPsinglePageProj1DbContextFactory : IDesignTimeDbContextFactory<ABPsinglePageProj1DbContext>
    {
        public ABPsinglePageProj1DbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<ABPsinglePageProj1DbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            ABPsinglePageProj1DbContextConfigurer.Configure(builder, configuration.GetConnectionString(ABPsinglePageProj1Consts.ConnectionStringName));

            return new ABPsinglePageProj1DbContext(builder.Options);
        }
    }
}
