using lb8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8.Classes
{
    class PayCalculator : IPayCalculator
    {
        private IPayCalculationStrategy _strategy;

        public PayCalculator(IPayCalculationStrategy strategy)
        {
            _strategy = strategy;
        }

        public decimal CalculateAveragePay(List<IJobType> jobTypes)
        {
            return _strategy.CalculateAveragePay(jobTypes);
        }
    }
}
