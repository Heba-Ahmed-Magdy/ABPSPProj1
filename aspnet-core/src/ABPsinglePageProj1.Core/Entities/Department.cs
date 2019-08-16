using Abp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABPsinglePageProj1.Entities
{
   public class Department:Entity<Guid>
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public string EstablishDate { get; set; }
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
