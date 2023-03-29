using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    public class WorkHours
    {
        public int ID { get; set; }
        public Employee Employee { get; set; }
        public Contract Contract { get; set; }
        public  WorkType WorkType { get; set; }
        public int Hours { get; set; }
        public DateTime Insertdate { get; set; }
        public string Insertuser { get; set; }

        public WorkHours(int iD, Employee employee, Contract contract, WorkType workType, int hours, DateTime insertdate, string insertuser)
        {
            ID = iD;
            Employee = employee;
            Contract = contract;
            WorkType = workType;
            Hours = hours;
            Insertdate = insertdate;
            Insertuser = insertuser;
        }
    }
}
