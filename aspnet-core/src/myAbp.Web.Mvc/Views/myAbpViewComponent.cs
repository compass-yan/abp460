using Abp.AspNetCore.Mvc.ViewComponents;

namespace myAbp.Web.Views
{
    public abstract class myAbpViewComponent : AbpViewComponent
    {
        protected myAbpViewComponent()
        {
            LocalizationSourceName = myAbpConsts.LocalizationSourceName;
        }
    }
}
