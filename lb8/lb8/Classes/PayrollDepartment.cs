using lb8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8.Classes
{
    // Класс для отдела расчета зарплаты
    class PayrollDepartment
    {
        private List<IJobType> _jobTypes = new List<IJobType>();
        private IPayCalculator _payCalculator;

        public PayrollDepartment(IPayCalculator payCalculator)
        {
            _payCalculator = payCalculator;
        }

        public void AddJobType(IJobType jobType)
        {
            _jobTypes.Add(jobType);
        }

        public decimal CalculateAveragePay()
        {
            return _payCalculator.CalculateAveragePay(_jobTypes);
        }
    }
}
