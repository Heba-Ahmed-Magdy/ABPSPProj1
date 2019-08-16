using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ABPsinglePageProj1.Entities;
using ABPsinglePageProj1.EntityFrameworkCore;
using Abp.Domain.Repositories;
using ABPsinglePageProj1.Entities.DTO;
using Abp.Application.Services.Dto;
using ABPsinglePageProj1.EntitiesAppServices.Dto;
using ABPsinglePageProj1.Controllers;

namespace ABPsinglePageProj1.Web.Host.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeesController : ABPsinglePageProj1ControllerBase
    {
        private readonly IRepository<Employee,Guid> _EmpRepo;
        private readonly EmployeeAppService _EmpAppServ ;
        private readonly PagedAndSortedResultRequestDto _PASRR ;
        private readonly EntityDto<Guid> _entityDto;
       // private readonly FilteredPagedAndSortedResultRequestDto _FPASRR;


        public EmployeesController(IRepository<Employee,Guid> EmpRepo,
            EmployeeAppService EmpAppServ, PagedAndSortedResultRequestDto PASRR,
            EntityDto<Guid> entityDto)
        {
            _EmpRepo = EmpRepo;
            _EmpAppServ = EmpAppServ;
            _PASRR = PASRR;
            _entityDto = entityDto;
          //  _FPASRR = FPASRR;
        }

        // GET: api/Employees

        [HttpGet("~/employees")]
        
        public async Task<PagedResultDto<EmployeeDto>> GetEmployees()
        {
            return await _EmpAppServ.GetAll(_PASRR);
        }

        // GET: api/Employees

        //[HttpGet]
        //[Route("")]
        //public async Task<PagedResultDto<EmployeeDto>> FilteredGetEmployees(PagedAndSortedResultRequestDto PASRR)
        //{
        //    return await _EmpAppServ.GetAllFilteredAsync(_FPASRR);
        //}

        // GET: api/Employees/5
        //[HttpGet("{id}")]
        //public async Task<EmployeeDto> GetEmployee(Guid id)
        //{
        //    return await _EmpAppServ.Get(_entityDto);

        //}



        // PUT: api/Employees/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> PutEmployee(Guid id, Employee employee)
        //{
        //    if (id != employee.Id)
        //    {
        //        return BadRequest();
        //    }

        //    _EmpRepo.Entry(employee).State = EntityState.Modified;

        //    try
        //    {
        //        await _EmpRepo.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!EmployeeExists(id))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return NoContent();
        //}

        //// POST: api/Employees
        //[HttpPost]
        //public async Task<ActionResult<Employee>> PostEmployee(Employee employee)
        //{
        //    _EmpRepo.Employees.Add(employee);
        //    await _EmpRepo.SaveChangesAsync();

        //    return CreatedAtAction("GetEmployee", new { id = employee.Id }, employee);
        //}

        //// DELETE: api/Employees/5
        //[HttpDelete("{id}")]
        //public async Task<ActionResult<Employee>> DeleteEmployee(Guid id)
        //{
        //    var employee = await _EmpRepo.Employees.FindAsync(id);
        //    if (employee == null)
        //    {
        //        return NotFound();
        //    }

        //    _EmpRepo.Employees.Remove(employee);
        //    await _EmpRepo.SaveChangesAsync();

        //    return employee;
        //}

        //private bool EmployeeExists(Guid id)
        //{
        //    return _EmpRepo.Employees.Any(e => e.Id == id);
        //}
    }
}
