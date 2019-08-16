using Abp.AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;
using ABPsinglePageProj1.Entities;
using Abp.Application.Services.Dto;

namespace ABPsinglePageProj1.Entities.DTO
{
    [AutoMap(typeof(Employee))]
    public class EmployeeDto:EntityDto<Guid>
    {
        public string Name { get; set; }
        public int age { get; set; }
        public Guid DepartmentId { get; set; }
    }
}
