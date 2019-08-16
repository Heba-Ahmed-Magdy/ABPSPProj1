using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPsinglePageProj1.Authorization;

namespace ABPsinglePageProj1
{
    [DependsOn(
        typeof(ABPsinglePageProj1CoreModule), 
        typeof(AbpAutoMapperModule))]
    public class ABPsinglePageProj1ApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<ABPsinglePageProj1AuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(ABPsinglePageProj1ApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
