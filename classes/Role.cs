using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    public class Role
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool Permission { get; set; }

        public Role(int iD, string name, bool permission)
        {
            ID = iD;
            Name = name;
            Permission = permission;
        }
    }
}
