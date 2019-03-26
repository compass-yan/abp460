using System.Threading.Tasks;
using myAbp.Configuration.Dto;

namespace myAbp.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
