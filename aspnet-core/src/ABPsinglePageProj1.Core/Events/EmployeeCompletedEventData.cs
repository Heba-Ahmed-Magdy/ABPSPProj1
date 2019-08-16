using Abp.Events.Bus;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABPsinglePageProj1.Events
{
   public class EmployeeCompletedEventData:EventData
    {
        public int empId { get; set; }
        public string empname { get; set; }
        public DateTime empcreationtime { get; set; }
        public long? empcreatorid { get; set; }
    }
}
