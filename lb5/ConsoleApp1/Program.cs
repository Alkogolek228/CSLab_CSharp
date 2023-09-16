using ConsoleApp1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SalaryCalculator;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            PayrollDepartment payrollDepartment = new PayrollDepartment();

            // ввод информации о различных видах работ
            payrollDepartment.AddWorkType("Программист", 2000);
            payrollDepartment.AddWorkType("Дизайнер", 1500);
            payrollDepartment.AddWorkType("Тестировщик", 1800);

            // ввод информации о работниках и выполненных ими работах
            payrollDepartment.AddEmployee("Иванов", "Программист", 160);
            payrollDepartment.AddEmployee("Петров", "Дизайнер", 120);
            payrollDepartment.AddEmployee("Сидоров", "Тестировщик", 140);

            // вывод зарплаты для работника по фамилии
            Console.Write("Введите фамилию работника: ");
            string lastName = Console.ReadLine();
            int salary = payrollDepartment.GetSalaryByLastName(lastName);
            if (salary == -1)
            {
                Console.WriteLine("Работник не найден");
            }
            else
            {
                Console.WriteLine($"Зарплата для {lastName}: {salary}");
            }

            // вывод суммы выплат всем работникам
            int totalSalary = payrollDepartment.GetTotalSalary();
            Console.WriteLine($"Общая сумма выплат: {totalSalary}");

            Console.ReadLine();
        }
    }
}