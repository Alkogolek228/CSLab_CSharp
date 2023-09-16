using _2lab1_2.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab1_2.Entities
{
    public class Journal
    {
        private MyCustomCollection<string> events;

        public Journal()
        {
            events = new MyCustomCollection<string>();
        }

        public void RegisterEmployeeAdded(object sender, EmployeeChangedEventArgs e)
        {
            events.Add($"Добавлен работник: {e.Employee.FirstName} {e.Employee.LastName}");
        }

        public void RegisterEmployeeRemoved(object sender, EmployeeChangedEventArgs e)
        {
            events.Add($"Удален работник: {e.Employee.FirstName} {e.Employee.LastName}");
        }

        public void RegisterWorkPerformed(object sender, WorkPerformedEventArgs e)
        {
            events.Add($"Выполнена работа '{e.Work.WorkName}' работником: {e.Employee.FirstName} {e.Employee.LastName}");
        }

        public void DisplayEvents()
        {
            Console.WriteLine("Журнал событий:");
            foreach (var ev in events)
            {
                Console.WriteLine(ev);
            }
        }
    }
}
