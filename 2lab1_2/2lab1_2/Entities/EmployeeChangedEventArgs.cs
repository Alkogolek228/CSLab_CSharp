using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab1_2.Entities
{
    public class EmployeeChangedEventArgs : EventArgs
    {
        public Employee Employee { get; }

        public EmployeeChangedEventArgs(Employee employee)
        {
            Employee = employee;
        }
    }
}
