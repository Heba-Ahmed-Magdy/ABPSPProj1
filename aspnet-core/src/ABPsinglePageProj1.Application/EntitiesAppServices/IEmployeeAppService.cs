using Abp.Application.Services;
using Abp.Application.Services.Dto;
using ABPsinglePageProj1.Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ABPsinglePageProj1.EntitiesAppServices.Dto
{
    public class FilteredPagedAndSortedResultRequestDto : PagedAndSortedResultRequestDto
    {
        public string FilteringString { get; set; }

    }
    public interface IEmployeeAppService : IAsyncCrudAppService<EmployeeDto, Guid>
    {
        Task<PagedResultDto<EmployeeDto>> GetAllFilteredAsync(FilteredPagedAndSortedResultRequestDto input);
        int GetEmployeesLength();
    }
}
