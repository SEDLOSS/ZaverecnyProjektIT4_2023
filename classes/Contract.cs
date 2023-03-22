using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    internal class Contract
    {
        public int ContactNumber { get; set; }
        public string Customer { get; set; }
        public string Description { get; set; }

        public Contract(int contactNumber, string customer, string description)
        {
            ContactNumber = contactNumber;
            Customer = customer;
            Description = description;
        }
    }
}
