using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    public class User
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public Role Role { get; set; }

        public User(int id, string name, Role role)
        {
            ID = id;
            Name = name;
            Role = role;
        }
    }
}
