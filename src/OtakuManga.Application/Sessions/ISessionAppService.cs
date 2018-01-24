using System.Threading.Tasks;
using Abp.Application.Services;
using OtakuManga.Sessions.Dto;

namespace OtakuManga.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
