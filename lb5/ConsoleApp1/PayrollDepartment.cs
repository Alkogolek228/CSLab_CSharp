using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SalaryCalculator
{
    public class PayrollDepartment
    {
        private List<Employee> _employees = new List<Employee>();
        private List<WorkType> _workTypes = new List<WorkType>();

        public void AddEmployee(string lastName, string workTypeName, int hours)
        {
            WorkType workType = _workTypes.FirstOrDefault(w => w.Name == workTypeName);
            if (workType == null)
            {
                throw new System.Exception("Вид работы не найден");
            }

            Employee employee = new Employee(lastName, workType, hours);
            _employees.Add(employee);
        }

        public void AddWorkType(string name, int rate)
        {
            WorkType workType = new WorkType(name, rate);
            _workTypes.Add(workType);
        }

        public int GetSalaryByLastName(string lastName)
        {
            Employee employee = _employees.FirstOrDefault(e => e.LastName == lastName);
            if (employee == null)
            {
                return -1;
            }

            return employee.CalculateSalary();
        }

        public int GetTotalSalary()
        {
            return _employees.Sum(e => e.CalculateSalary());
        }
    }

    public class Employee
    {
        public string LastName { get; set; }
        public WorkType WorkType { get; set; }
        public int Hours { get; set; }

        public Employee(string lastName, WorkType workType, int hours)
        {
            LastName = lastName;
            WorkType = workType;
            Hours = hours;
        }

        public int CalculateSalary()
        {
            return WorkType.Rate * Hours;
        }
    }

    public class WorkType
    {
        public string Name { get; set; }
        public int Rate { get; set; }

        public WorkType(string name, int rate)
        {
            Name = name;
            Rate = rate;
        }
    }
}
