using System.Threading.Tasks;
using Abp.Application.Services;
using Abp.Application.Services.Dto;
using OtakuManga.Roles.Dto;
using OtakuManga.Users.Dto;

namespace OtakuManga.Users
{
    public interface IUserAppService : IAsyncCrudAppService<UserDto, long, PagedResultRequestDto, CreateUserDto, UserDto>
    {
        Task<ListResultDto<RoleDto>> GetRoles();

        Task ChangeLanguage(ChangeUserLanguageDto input);
    }
}
