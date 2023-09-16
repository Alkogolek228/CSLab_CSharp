using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2lab1_2.Collections;

namespace _2lab1_2.Contracts
{
    public interface IEmployee
    {
        string FirstName { get; }
        string LastName { get; }
        MyCustomCollection<IWork> WorksPerformed { get; }
    }
}
