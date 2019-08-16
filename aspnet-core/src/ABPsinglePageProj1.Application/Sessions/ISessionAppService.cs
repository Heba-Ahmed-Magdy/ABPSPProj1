using System.Threading.Tasks;
using Abp.Application.Services;
using ABPsinglePageProj1.Sessions.Dto;

namespace ABPsinglePageProj1.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
