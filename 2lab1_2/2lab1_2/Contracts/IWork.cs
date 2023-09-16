using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab1_2.Contracts
{
    public interface IWork
    {
        string WorkName { get; }
        decimal CalculateSalary();
    }
}
