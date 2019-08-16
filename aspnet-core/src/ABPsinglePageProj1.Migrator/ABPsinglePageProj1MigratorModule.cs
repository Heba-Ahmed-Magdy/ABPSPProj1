using Microsoft.Extensions.Configuration;
using Castle.MicroKernel.Registration;
using Abp.Events.Bus;
using Abp.Modules;
using Abp.Reflection.Extensions;
using ABPsinglePageProj1.Configuration;
using ABPsinglePageProj1.EntityFrameworkCore;
using ABPsinglePageProj1.Migrator.DependencyInjection;

namespace ABPsinglePageProj1.Migrator
{
    [DependsOn(typeof(ABPsinglePageProj1EntityFrameworkModule))]
    public class ABPsinglePageProj1MigratorModule : AbpModule
    {
        private readonly IConfigurationRoot _appConfiguration;

        public ABPsinglePageProj1MigratorModule(ABPsinglePageProj1EntityFrameworkModule abpProjectNameEntityFrameworkModule)
        {
            abpProjectNameEntityFrameworkModule.SkipDbSeed = true;

            _appConfiguration = AppConfigurations.Get(
                typeof(ABPsinglePageProj1MigratorModule).GetAssembly().GetDirectoryPathOrNull()
            );
        }

        public override void PreInitialize()
        {
            Configuration.DefaultNameOrConnectionString = _appConfiguration.GetConnectionString(
                ABPsinglePageProj1Consts.ConnectionStringName
            );

            Configuration.BackgroundJobs.IsJobExecutionEnabled = false;
            Configuration.ReplaceService(
                typeof(IEventBus), 
                () => IocManager.IocContainer.Register(
                    Component.For<IEventBus>().Instance(NullEventBus.Instance)
                )
            );
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(ABPsinglePageProj1MigratorModule).GetAssembly());
            ServiceCollectionRegistrar.Register(IocManager);
        }
    }
}
