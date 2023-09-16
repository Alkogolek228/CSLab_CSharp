using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2lab1_2.Contracts;

namespace _2lab1_2.Entities
{
    public class WorkPerformedEventArgs : EventArgs
    {
        public IEmployee Employee { get; }
        public IWork Work { get; }

        public WorkPerformedEventArgs(IEmployee employee, IWork work)
        {
            Employee = employee;
            Work = work;
        }
    }
}
