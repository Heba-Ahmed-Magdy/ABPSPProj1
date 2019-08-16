using Abp.MultiTenancy;
using ABPsinglePageProj1.Authorization.Users;

namespace ABPsinglePageProj1.MultiTenancy
{
    public class Tenant : AbpTenant<User>
    {
        public Tenant()
        {            
        }

        public Tenant(string tenancyName, string name)
            : base(tenancyName, name)
        {
        }
    }
}
