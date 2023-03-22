using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    internal class WorkHours
    {
        public Employee Employee { get; set; }
        public Contract Contract { get; set; }
        public  WorkType WorkType { get; set; }
        public int Hours { get; set; }

        public WorkHours(Employee employee, Contract contract, WorkType workType, int hours)
        {
            Employee = employee;
            Contract = contract;
            WorkType = workType;
            Hours = hours;
        }
    }
}
