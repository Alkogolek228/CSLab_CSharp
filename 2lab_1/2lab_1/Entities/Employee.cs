using _2lab_1.Collections;
using _2lab_1.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_1.Entities
{
    public class Employee
    {
        public string LastName { get; set; }
        public MyCustomCollection<WorkType> WorkTypes { get; set; } = new MyCustomCollection<WorkType>();
    }
    
}
