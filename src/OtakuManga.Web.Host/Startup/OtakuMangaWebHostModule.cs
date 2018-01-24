using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Abp.Modules;
using Abp.Reflection.Extensions;
using OtakuManga.Configuration;

namespace OtakuManga.Web.Host.Startup
{
    [DependsOn(
       typeof(OtakuMangaWebCoreModule))]
    public class OtakuMangaWebHostModule: AbpModule
    {
        private readonly IHostingEnvironment _env;
        private readonly IConfigurationRoot _appConfiguration;

        public OtakuMangaWebHostModule(IHostingEnvironment env)
        {
            _env = env;
            _appConfiguration = env.GetAppConfiguration();
        }

        public override void Initialize()
        {
            IocManager.RegisterAssemblyByConvention(typeof(OtakuMangaWebHostModule).GetAssembly());
        }
    }
}
