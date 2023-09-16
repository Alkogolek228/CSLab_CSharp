using _2lab_1.Collections;
using _2lab_1.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_1.Contracts
{
    public interface IEmployeeSystem
    {
        void AddWorkType(WorkType workType);
        void AddEmployee(Employee employee);
        MyCustomCollection<Employee> GetEmployeesByWorkType(string workTypeName);
        decimal GetSalary(string employeeLastName);
        decimal CalculateTotalPayroll();
    }
}
