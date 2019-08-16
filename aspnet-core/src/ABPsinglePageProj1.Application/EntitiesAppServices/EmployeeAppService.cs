using Abp.Application.Services;
using Abp.Domain.Repositories;
using ABPsinglePageProj1.Entities.DTO;
using ABPsinglePageProj1.EntitiesAppServices.Dto;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using Abp.Application.Services.Dto;


using ABPsinglePageProj1.Events;
using Abp.Events.Bus;
using Abp.Domain.Entities;

namespace ABPsinglePageProj1.Entities
{
    public class EmployeeAppService 
        : AsyncCrudAppService<Employee, EmployeeDto,Guid, PagedAndSortedResultRequestDto,EmployeeDto>,IEmployeeAppService, IApplicationService
    {
        private readonly IRepository<Employee, Guid> empRepo;
        public IEventBus EventBus { get; set; }

        public EmployeeAppService(IRepository<Employee,Guid> _empRepo)
            : base(_empRepo)
        {

            empRepo = _empRepo;
            EventBus = NullEventBus.Instance;
        }

        public override async Task<EmployeeDto> Create(EmployeeDto input)
        {
            CheckCreatePermission();

            var entity = MapToEntity(input);

            await Repository.InsertAsync(entity);
            await CurrentUnitOfWork.SaveChangesAsync();
           EventBus.Trigger(new EmployeeCompletedEventData { empId = 19,empcreationtime=entity.CreationTime });
            return MapToEntityDto(entity);
        }


        public async Task<PagedResultDto<EmployeeDto>> GetAllFilteredAsync(FilteredPagedAndSortedResultRequestDto input)
        {
            
            CheckGetAllPermission();

            var query = CreateFilteredQuery(input);

            var totalCount = await AsyncQueryableExecuter.CountAsync(query);

            query = ApplySorting(query, input);
            query = ApplyPaging(query, input);

            var entities = await AsyncQueryableExecuter.ToListAsync(query);
            var FilteredEntities = entities.FindAll(x => x.Name.Contains(input.FilteringString));
            EventBus.Trigger(new EmployeeCompletedEventData { empId = 19 });

            return new PagedResultDto<EmployeeDto>(
                totalCount,
                FilteredEntities.Select(MapToEntityDto).ToList()
            );
        }

        public int GetEmployeesLength()
        {
            return empRepo.Count();
        }
        public void hardDel(Guid x)
        {
            Employee e = empRepo.Get(x);
            e.SetData("emp name IExtendableObject :", e.Name);
            empRepo.HardDelete<Employee, Guid>(e);
            EventBus.Trigger(new EmployeeCompletedEventData { empname = e.ExtensionData });


        }

        public /*async*/  void delUpd(EmployeeDto input)
        {
            //var x=this.Update(input).Result;
            //this.Delete( input);

            //OR
            //for result it must be async fnc

            this.Delete(input);
            this.Update(input);


        }
      

    }
}
