using Abp.AutoMapper;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OtakuManga.Authorization;

namespace OtakuManga
{
    [DependsOn(
        typeof(OtakuMangaCoreModule), 
        typeof(AbpAutoMapperModule))]
    public class OtakuMangaApplicationModule : AbpModule
    {
        public override void PreInitialize()
        {
            Configuration.Authorization.Providers.Add<OtakuMangaAuthorizationProvider>();
        }

        public override void Initialize()
        {
            var thisAssembly = typeof(OtakuMangaApplicationModule).GetAssembly();

            IocManager.RegisterAssemblyByConvention(thisAssembly);

            Configuration.Modules.AbpAutoMapper().Configurators.Add(
                // Scan the assembly for classes which inherit from AutoMapper.Profile
                cfg => cfg.AddProfiles(thisAssembly)
            );
        }
    }
}
