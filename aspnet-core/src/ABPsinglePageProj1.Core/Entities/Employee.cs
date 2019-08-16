using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ABPsinglePageProj1.Entities
{
    public class Employee:FullAuditedEntity<Guid> /*AuditedEntity<Guid>*/, IExtendableObject
    {
       
        public string Name  { get; set; }
        public int age { get; set; }
        public decimal Salary  { get; set; }

        [ForeignKey("Department")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid DepartmentId { get; set; }
        public Department Department { get; set; }
        public string ExtensionData { get; set; }
        //[NotMapped]
        //public AuditedEntity auditedEntity { get; set; }

    }
}
