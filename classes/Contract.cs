using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    public class Contract
    {
        public int Id { get; set; }
        public string Customer { get; set; }
        public string Description { get; set; }

        public Contract(int id, string customer, string description)
        {
            Id = id;
            Customer = customer;
            Description = description;
        }
        public Contract(string customer, string description)
        {
            Customer = customer;
            Description = description;
        }
    }
}
