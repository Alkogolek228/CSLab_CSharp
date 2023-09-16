using _2lab_1.Collections;
using _2lab_1.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_1.Entities
{
    public class EmployeeSystem : IEmployeeSystem
    {
        private MyCustomCollection<WorkType> workTypes = new MyCustomCollection<WorkType>();
        private MyCustomCollection<Employee> employees = new MyCustomCollection<Employee>();

        public void AddWorkType(WorkType workType)
        {
            workTypes.Add(workType);
        }

        public void AddEmployee(Employee employee)
        {
            employees.Add(employee);
        }

        public MyCustomCollection<Employee> GetEmployeesByWorkType(string workTypeName)
        {
            var result = new MyCustomCollection<Employee>();
            for (int i = 0; i < employees.Count; i++)
            {
                var employee = employees[i];
                if (employee.WorkTypes.Any(wt => wt.Name == workTypeName))
                {
                    result.Add(employee);
                }
            }
            return result;
        }

        public decimal GetSalary(string employeeLastName)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                var employee = employees[i];
                if (employee.LastName == employeeLastName)
                {
                    decimal totalSalary = 0;
                    for (int j = 0; j < employee.WorkTypes.Count; j++)
                    {
                        var workType = employee.WorkTypes[j];
                        totalSalary += Mult(workType.RatePerHour, HoursWorked());
                    }
                    return totalSalary;
                }
            }
            return 0;
        }

        public decimal CalculateTotalPayroll()
        {
            decimal totalPayroll = 0;
            for (int i = 0; i < employees.Count; i++)
            {
                var employee = employees[i];
                for (int j = 0; j < employee.WorkTypes.Count; j++)
                {
                    var workType = employee.WorkTypes[j];
                    totalPayroll += Mult(workType.RatePerHour, HoursWorked());
                }
            }
            return totalPayroll;
        }

        private T Mult<T>(T left, T right) where T : IMultiplyOperators<T,T,T> {
            return left * right;
        }

        public decimal HoursWorked() { return 160m; }
    }
}
