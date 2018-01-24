using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using OtakuManga.Configuration;
using OtakuManga.Web;

namespace OtakuManga.EntityFrameworkCore
{
    /* This class is needed to run "dotnet ef ..." commands from command line on development. Not used anywhere else */
    public class OtakuMangaDbContextFactory : IDesignTimeDbContextFactory<OtakuMangaDbContext>
    {
        public OtakuMangaDbContext CreateDbContext(string[] args)
        {
            var builder = new DbContextOptionsBuilder<OtakuMangaDbContext>();
            var configuration = AppConfigurations.Get(WebContentDirectoryFinder.CalculateContentRootFolder());

            OtakuMangaDbContextConfigurer.Configure(builder, configuration.GetConnectionString(OtakuMangaConsts.ConnectionStringName));

            return new OtakuMangaDbContext(builder.Options);
        }
    }
}
