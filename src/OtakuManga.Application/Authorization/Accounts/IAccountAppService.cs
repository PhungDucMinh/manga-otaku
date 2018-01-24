using System.Threading.Tasks;
using Abp.Application.Services;
using OtakuManga.Authorization.Accounts.Dto;

namespace OtakuManga.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
