using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    public class Role
    {
        public string Name { get; set; }
        public int RoleID { get; set; }

        public Role(string name, int roleID)
        {
            Name = name;
            RoleID = roleID;
        }
    }
}
