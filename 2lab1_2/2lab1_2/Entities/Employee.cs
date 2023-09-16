using _2lab1_2.Collections;
using _2lab1_2.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2lab1_2.Entities
{
    public class Employee : IEmployee
    {
        public string FirstName { get; }
        public string LastName { get; }
        public MyCustomCollection<IWork> WorksPerformed { get; }

        public event EventHandler<EmployeeChangedEventArgs> EmployeeAdded;
        public event EventHandler<EmployeeChangedEventArgs> EmployeeRemoved;
        public event EventHandler<WorkPerformedEventArgs> WorkPerformed;

        public Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
            WorksPerformed = new MyCustomCollection<IWork>();
        }

        public void AddWork(IWork work)
        {
            WorksPerformed.Add(work);
            OnWorkPerformed(new WorkPerformedEventArgs(this, work));
        }
        protected virtual void OnWorkPerformed(WorkPerformedEventArgs e)
        {
            WorkPerformed?.Invoke(this, e);
        }

        public decimal CalculateTotalSalary()
        {
            decimal totalSalary = 0;
            foreach (var work in WorksPerformed)
            {
                totalSalary += work.CalculateSalary();
            }
            return totalSalary;
        }
    }
}
