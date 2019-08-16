using System.Threading.Tasks;
using ABPsinglePageProj1.Configuration.Dto;

namespace ABPsinglePageProj1.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
