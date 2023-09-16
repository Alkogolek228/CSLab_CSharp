using lb8.Classes;
using lb8.Interfaces;

namespace lb8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создание объектов видов работ
            IJobType jobType1 = new JobType { Name = "Тестировщик", BasePay = 1000, Bonus = 10 };
            IJobType jobType2 = new JobType { Name = "Программист", BasePay = 1500, Bonus = 5 };
            IJobType jobType3 = new JobType { Name = "Дизайнер", BasePay = 1200, Bonus = 7 };

            // Создание объекта отдела расчета зарплаты с использованием стратегии вычисления средней величины оплаты
            IPayCalculator allPayCalculator = new PayCalculator(new AllPayCalculationStrategy());
            PayrollDepartment payrollDepartment1 = new PayrollDepartment(allPayCalculator);

            // Добавление видов работ в отдел расчета зарплаты
            payrollDepartment1.AddJobType(jobType1);
            payrollDepartment1.AddJobType(jobType2);
            payrollDepartment1.AddJobType(jobType3);

            // Вычисление средней величины оплаты для всех видов работ
            decimal averagePay1 = payrollDepartment1.CalculateAveragePay();
            Console.WriteLine($"Средняя величина оплаты за все виды работ: {averagePay1}");

            // Создание объекта отдела расчета зарплаты с использованием стратегии вычисления средней величины оплаты без учета надбавок
            IPayCalculator basePayCalculator = new PayCalculator(new BasePayCalculationStrategy());
            PayrollDepartment payrollDepartment2 = new PayrollDepartment(basePayCalculator);

            // Добавление видов работ в отдел расчета зарплаты
            payrollDepartment2.AddJobType(jobType1);
            payrollDepartment2.AddJobType(jobType2);
            payrollDepartment2.AddJobType(jobType3);

            // Вычисление средней величины оплаты без учета надбавок
            decimal averagePay2 = payrollDepartment2.CalculateAveragePay();
            Console.WriteLine($"Средняя величина оплаты без учета надбавок: {averagePay2}");

            Console.ReadKey();
        }
    }
}