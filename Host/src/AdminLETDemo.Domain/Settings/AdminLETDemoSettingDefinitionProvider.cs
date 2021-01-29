using Volo.Abp.Settings;

namespace AdminLETDemo.Settings
{
    public class AdminLETDemoSettingDefinitionProvider : SettingDefinitionProvider
    {
        public override void Define(ISettingDefinitionContext context)
        {
            //Define your own settings here. Example:
            //context.Add(new SettingDefinition(AdminLETDemoSettings.MySetting1));
        }
    }
}
