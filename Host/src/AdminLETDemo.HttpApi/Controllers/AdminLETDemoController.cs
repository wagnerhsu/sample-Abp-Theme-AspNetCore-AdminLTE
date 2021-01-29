using AdminLETDemo.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace AdminLETDemo.Controllers
{
    /* Inherit your controllers from this class.
     */
    public abstract class AdminLETDemoController : AbpController
    {
        protected AdminLETDemoController()
        {
            LocalizationResource = typeof(AdminLETDemoResource);
        }
    }
}