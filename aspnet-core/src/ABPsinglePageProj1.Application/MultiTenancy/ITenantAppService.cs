using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPsinglePageProj1.MultiTenancy.Dto;

namespace ABPsinglePageProj1.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

