using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using OtakuManga.Authorization.Roles;
using OtakuManga.Authorization.Users;
using OtakuManga.MultiTenancy;

namespace OtakuManga.EntityFrameworkCore
{
    public class OtakuMangaDbContext : AbpZeroDbContext<Tenant, Role, User, OtakuMangaDbContext>
    {
        /* Define a DbSet for each entity of the application */
        
        public OtakuMangaDbContext(DbContextOptions<OtakuMangaDbContext> options)
            : base(options)
        {
        }
    }
}
