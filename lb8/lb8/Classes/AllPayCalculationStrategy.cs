using lb8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8.Classes
{
    // Реализация стратегии вычисления средней величины оплаты для всех видов работ
    class AllPayCalculationStrategy : IPayCalculationStrategy
    {
        public decimal CalculateAveragePay(List<IJobType> jobTypes)
        {
            decimal totalPay = 0;
            foreach (IJobType jobType in jobTypes)
            {
                totalPay += jobType.BasePay + (jobType.BasePay * jobType.Bonus / 100);
            }
            return totalPay / jobTypes.Count;
        }
    }
}
