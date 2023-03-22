using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZaverecnyProjektIT4_2023.classes
{
    public class Contract
    {
        public int ContactNumber { get; set; }
        public string Customer { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDay { get; set; }

        public Contract(int contactNumber, string customer, string description, DateTime createdDay)
        {
            ContactNumber = contactNumber;
            Customer = customer;
            Description = description;
            CreatedDay = createdDay;
        }
    }
}
