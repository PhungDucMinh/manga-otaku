using System.Threading.Tasks;
using OtakuManga.Configuration.Dto;

namespace OtakuManga.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
