using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8.Interfaces
{
    // Интерфейс для стратегии вычисления средней величины оплаты
    interface IPayCalculationStrategy
    {
        decimal CalculateAveragePay(List<IJobType> jobTypes);
    }
}
