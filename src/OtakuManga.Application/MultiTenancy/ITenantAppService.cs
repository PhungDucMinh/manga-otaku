using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OtakuManga.MultiTenancy.Dto;

namespace OtakuManga.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}
