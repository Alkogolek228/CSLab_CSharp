using _2lab1_2.Entities;

namespace _2lab1_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var journal = new Journal();

            var work1 = new Work("Работа 1", 1000);
            var work2 = new Work("Работа 2", 1200);

            // Создаем работников и добавляем выполняемые ими работы
            var employee1 = new Employee("Иван", "Иванов");

            employee1.EmployeeAdded += journal.RegisterEmployeeAdded;
            employee1.EmployeeRemoved += journal.RegisterEmployeeRemoved;
            employee1.WorkPerformed += journal.RegisterWorkPerformed;

            employee1.AddWork(work1);
            employee1.AddWork(work2);

            var employee2 = new Employee("Петр", "Петров");

            employee2.EmployeeAdded += journal.RegisterEmployeeAdded;
            employee2.EmployeeRemoved += journal.RegisterEmployeeRemoved;
            employee2.WorkPerformed += journal.RegisterWorkPerformed;

            employee2.AddWork(work1);

            // Выводим информацию о работниках и их выполняемых работах
            Console.WriteLine($"Имя: {employee1.FirstName}, Фамилия: {employee1.LastName}");
            Console.WriteLine("Выполняемые работы:");

            foreach (var work in employee1.WorksPerformed)
            {
                Console.WriteLine($"- {work.WorkName}");
            }
            Console.WriteLine($"Общая зарплата: {employee1.CalculateTotalSalary()}");

            Console.WriteLine();

            Console.WriteLine($"Имя: {employee2.FirstName}, Фамилия: {employee2.LastName}");
            Console.WriteLine("Выполняемые работы:");
            foreach (var work in employee2.WorksPerformed)
            {
                Console.WriteLine($"- {work.WorkName}");
            }
            Console.WriteLine($"Общая зарплата: {employee2.CalculateTotalSalary()}");

            // Вычисляем общую сумму выплат всем работникам
            decimal totalPayments = employee1.CalculateTotalSalary() + employee2.CalculateTotalSalary();
            Console.WriteLine($"Общая сумма выплат всем работникам: {totalPayments}");
            journal.DisplayEvents();
        }
    }
}