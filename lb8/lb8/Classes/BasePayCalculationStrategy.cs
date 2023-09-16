using lb8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8.Classes
{
    // Реализация стратегии вычисления средней величины оплаты без учета надбавок
    class BasePayCalculationStrategy : IPayCalculationStrategy
    {
        public decimal CalculateAveragePay(List<IJobType> jobTypes)
        {
            decimal totalPay = 0;
            foreach (IJobType jobType in jobTypes)
            {
                totalPay += jobType.BasePay;
            }
            return totalPay / jobTypes.Count;
        }
    }

}
