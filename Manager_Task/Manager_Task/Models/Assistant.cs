using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manager_Task.Models
{
    public class Assistant :Employee
    {
        public void GetFeedback(Employee employee)
        {
            if (employee.IsSuccessfull)
            {

            }
            else
            {
                Console.WriteLine();
            }
        }

    }
}
