using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    public class User
    {
        public string Name { get; set; }
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }

        public User(string name, byte[] hash, byte[] salt)
        {
            Name = name;
            Hash = hash;
            Salt = salt;
        }
    }
}
