using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABPsinglePageProj1.Entities.Dto
{
    [AutoMap(typeof(Department))]
    public class DepartmentDto:EntityDto<Guid>
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
