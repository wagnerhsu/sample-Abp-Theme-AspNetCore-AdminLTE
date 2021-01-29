using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace AdminLETDemo.Web
{
    [Dependency(ReplaceServices = true)]
    public class AdminLETDemoBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "AdminLETDemo";
    }
}
