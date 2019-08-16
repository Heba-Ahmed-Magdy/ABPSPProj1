using Abp.Dependency;
using Abp.Events.Bus.Handlers;
using System;
using System.Collections.Generic;
using System.Text;

namespace ABPsinglePageProj1.Events
{
    public class empEventHandler : IEventHandler<EmployeeCompletedEventData>, ITransientDependency
    {
        public void HandleEvent(EmployeeCompletedEventData eventData)
        {
            string txt = "A task is completed by id = " + eventData.empname+" :: "+eventData.empcreatorid+" :: "+eventData.empcreationtime;
            System.IO.File.WriteAllText(@"C:\Users\heba.magdy\Desktop\traingCourses\boilerPlate\ABPsinglePageProj1\4.7.1\aspnet-core\WriteText.txt", txt);


        }
    }
}
