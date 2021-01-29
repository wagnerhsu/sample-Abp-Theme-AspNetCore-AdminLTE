using AdminLETDemo.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace AdminLETDemo.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class AdminLETDemoPageModel : AbpPageModel
    {
        protected AdminLETDemoPageModel()
        {
            LocalizationResourceType = typeof(AdminLETDemoResource);
        }
    }
}