using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ABPsinglePageProj1.Authorization.Roles;
using ABPsinglePageProj1.Authorization.Users;
using ABPsinglePageProj1.MultiTenancy;
using ABPsinglePageProj1.Entities;

namespace ABPsinglePageProj1.EntityFrameworkCore
{
    public class ABPsinglePageProj1DbContext : AbpZeroDbContext<Tenant, Role, User, ABPsinglePageProj1DbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }
        public ABPsinglePageProj1DbContext(DbContextOptions<ABPsinglePageProj1DbContext> options)
            : base(options)
        {
        }
    }
}
