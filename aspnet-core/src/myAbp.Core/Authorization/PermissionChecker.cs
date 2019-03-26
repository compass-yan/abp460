using Abp.Authorization;
using myAbp.Authorization.Roles;
using myAbp.Authorization.Users;

namespace myAbp.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
