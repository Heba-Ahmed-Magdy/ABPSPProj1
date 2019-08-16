using Abp.Authorization;
using ABPsinglePageProj1.Authorization.Roles;
using ABPsinglePageProj1.Authorization.Users;

namespace ABPsinglePageProj1.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
