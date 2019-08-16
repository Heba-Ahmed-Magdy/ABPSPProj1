using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPsinglePageProj1.Configuration;
using Abp.Localization;

namespace ABPsinglePageProj1.Web.Host.Startup
{
    [DependsOn(
       typeof(ABPsinglePageProj1WebCoreModule))]
    public class ABPsinglePageProj1WebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public ABPsinglePageProj1WebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPsinglePageProj1WebHostModule).GetAssembly());
        }
        public override void PreInitialize()
        {
           
            base.PreInitialize();
        }
    }
}
