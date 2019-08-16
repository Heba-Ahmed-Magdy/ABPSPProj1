using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPsinglePageProj1.Entities;
using ABPsinglePageProj1.Entities.Dto;
using ABPsinglePageProj1.Entities.DTO;
using ABPsinglePageProj1.EntitiesAppServices.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ABPsinglePageProj1.EntitiesAppServices
{
    public interface IDepartmentAppService: IAsyncCrudAppService<DepartmentDto,Guid>
    {
        Task<PagedResultDto<DepartmentDto>> GetAllFilteredAsync(FilteredPagedAndSortedResultRequestDto input);

    }
}
