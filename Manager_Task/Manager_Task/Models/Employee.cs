using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Task.Models
{
    public class Employee
    {
        public string Name { get; set; }
        public bool  IsSuccessfull { get; set; }
        public decimal Salary { get; set; }

        public Employee(string name, bool issuccessfull, decimal salary)
        {
            Name = Name;
            IsSuccessfull = issuccessfull;
            Salary = salary;
        }

    }
}
