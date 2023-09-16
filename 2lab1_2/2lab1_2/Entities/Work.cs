using _2lab1_2.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab1_2.Entities
{
    public class Work : IWork
    {
        public string WorkName { get; }
        public decimal WorkRate { get; }

        public Work(string workName, decimal workRate)
        {
            WorkName = workName;
            WorkRate = workRate;
        }

        public decimal CalculateSalary()
        {
            // Реализуйте логику расчета зарплаты для данного вида работы
            // Например, return WorkRate * hoursWorked;
            return WorkRate;
        }
    }
}
