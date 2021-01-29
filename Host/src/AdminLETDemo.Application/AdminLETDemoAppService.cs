using System;
using System.Collections.Generic;
using System.Text;
using AdminLETDemo.Localization;
using Volo.Abp.Application.Services;

namespace AdminLETDemo
{
    /* Inherit your application services from this class.
     */
    public abstract class AdminLETDemoAppService : ApplicationService
    {
        protected AdminLETDemoAppService()
        {
            LocalizationResource = typeof(AdminLETDemoResource);
        }
    }
}
