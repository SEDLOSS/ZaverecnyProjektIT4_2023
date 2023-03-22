using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    internal class WorkType
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public WorkType(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
