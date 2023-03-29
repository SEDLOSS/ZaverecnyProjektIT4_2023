﻿using System;
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
        public byte[] Hash { get; set; }
        public byte[] Salt { get; set; }
        public int Roleid { get; set; }

        public User(int iD, string name, byte[] hash, byte[] salt, int roleid)
        {
            ID = iD;
            Name = name;
            Hash = hash;
            Salt = salt;
            Roleid = roleid;
        }
    }
}
