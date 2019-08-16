using Abp.Application.Services;
using Abp.Application.Services.Dto;
using Abp.Domain.Repositories;
using ABPsinglePageProj1.Entities.Dto;
using ABPsinglePageProj1.EntitiesAppServices;
using ABPsinglePageProj1.EntitiesAppServices.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABPsinglePageProj1.Entities
{
    public class DepartmentAppService
        :AsyncCrudAppService<Department,DepartmentDto,Guid>,IApplicationService
    {
        public DepartmentAppService(IRepository<Department,Guid>_departRepo)
            :base(_departRepo)
        {

        }
        public async Task<PagedResultDto<DepartmentDto>> GetAllFilteredAsync(FilteredPagedAndSortedResultRequestDto input)
        {
            CheckGetAllPermission();

            var query = CreateFilteredQuery(input);

            var totalCount = await AsyncQueryableExecuter.CountAsync(query);

            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);

            var entities = await AsyncQueryableExecuter.ToListAsync(query);
            var FilteredEntities = entities.FindAll(x => x.Name.Contains(input.FilteringString));

            return new PagedResultDto<DepartmentDto>(
                totalCount,
                FilteredEntities.Select(MapToEntityDto).ToList()
            );
        }

    }
}
