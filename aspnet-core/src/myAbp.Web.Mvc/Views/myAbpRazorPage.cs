using Microsoft.AspNetCore.Mvc.Razor.Internal;
using Abp.AspNetCore.Mvc.Views;
using Abp.Runtime.Session;

namespace myAbp.Web.Views
{
    public abstract class myAbpRazorPage<TModel> : AbpRazorPage<TModel>
    {
        [RazorInject]
        public IAbpSession AbpSession { get; set; }

        protected myAbpRazorPage()
        {
            LocalizationSourceName = myAbpConsts.LocalizationSourceName;
        }
    }
}
