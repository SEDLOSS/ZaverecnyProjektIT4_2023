using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    public class WorkType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public WorkType(int iD, string name, string description)
        {
            ID = iD;
            Name = name;
            Description = description;
        }
    }
}
