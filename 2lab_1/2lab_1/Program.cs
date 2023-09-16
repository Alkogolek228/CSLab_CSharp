using _2lab_1.Contracts;
using _2lab_1.Entities;
using System.Numerics;

namespace _2lab_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаем объект системы расчета зарплаты
            var payrollSystem = new EmployeeSystem();

            // Добавляем виды работ
            payrollSystem.AddWorkType(new WorkType ("Работа1", 10));
            payrollSystem.AddWorkType(new WorkType ("Работа2", 15));

            // Добавляем сотрудников
            var employee1 = new Employee { LastName = "Иванов" };
            employee1.WorkTypes.Add(new WorkType ("Работа1", 10));

            var employee2 = new Employee { LastName = "Петров" };
            employee2.WorkTypes.Add(new WorkType ("Работа2", 15 ));

            payrollSystem.AddEmployee(employee1);
            payrollSystem.AddEmployee(employee2);

            // Примеры использования функциональности системы
            Console.WriteLine("Сотрудники, выполнявшие работу 'Работа1':");
            var employeesForWork1 = payrollSystem.GetEmployeesByWorkType("Работа1");
            for (int i = 0; i < employeesForWork1.Count; i++)
            {
                var emp = employeesForWork1[i];
                Console.WriteLine(emp.LastName);
            }
            Console.WriteLine("Зарплата для сотрудника Иванов: " + payrollSystem.GetSalary("Иванов"));
            Console.WriteLine("Общая зарплата для всех сотрудников: " + payrollSystem.CalculateTotalPayroll());
        }
    }
}