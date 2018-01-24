using Abp.Authorization;
using OtakuManga.Authorization.Roles;
using OtakuManga.Authorization.Users;

namespace OtakuManga.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
