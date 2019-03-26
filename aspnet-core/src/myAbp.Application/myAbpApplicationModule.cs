using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using myAbp.Authorization;

namespace myAbp
{
    [DependsOn(
        typeof(myAbpCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class myAbpApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<myAbpAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(myAbpApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
