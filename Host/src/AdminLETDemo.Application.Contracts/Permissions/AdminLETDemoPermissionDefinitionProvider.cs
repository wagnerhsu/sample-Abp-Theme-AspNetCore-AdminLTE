using AdminLETDemo.Localization;
using Volo.Abp.Authorization.Permissions;
using Volo.Abp.Localization;

namespace AdminLETDemo.Permissions
{
    public class AdminLETDemoPermissionDefinitionProvider : PermissionDefinitionProvider
    {
        public override void Define(IPermissionDefinitionContext context)
        {
            var myGroup = context.AddGroup(AdminLETDemoPermissions.GroupName);

            //Define your own permissions here. Example:
            //myGroup.AddPermission(AdminLETDemoPermissions.MyPermission1, L("Permission:MyPermission1"));
        }

        private static LocalizableString L(string name)
        {
            return LocalizableString.Create<AdminLETDemoResource>(name);
        }
    }
}
