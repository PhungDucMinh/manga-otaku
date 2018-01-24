using System.Data.Common;
using Microsoft.EntityFrameworkCore;

namespace OtakuManga.EntityFrameworkCore
{
    public static class OtakuMangaDbContextConfigurer
    {
        public static void Configure(DbContextOptionsBuilder<OtakuMangaDbContext> builder, string connectionString)
        {
            builder.UseSqlServer(connectionString);
        }

        public static void Configure(DbContextOptionsBuilder<OtakuMangaDbContext> builder, DbConnection connection)
        {
            builder.UseSqlServer(connection);
        }
    }
}
