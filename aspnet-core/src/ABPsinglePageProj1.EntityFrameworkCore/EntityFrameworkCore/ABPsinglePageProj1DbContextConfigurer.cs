using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace ABPsinglePageProj1.EntityFrameworkCore
{
    public static class ABPsinglePageProj1DbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<ABPsinglePageProj1DbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<ABPsinglePageProj1DbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
