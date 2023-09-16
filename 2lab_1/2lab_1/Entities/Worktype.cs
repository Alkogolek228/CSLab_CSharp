using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2lab_1.Entities
{
    public class WorkType
    {
        public string Name { get; set; }
        public decimal RatePerHour { get; set; }

        public WorkType(string name, decimal ratePerHour = 0)
        {
            Name = name;
            RatePerHour = ratePerHour;
        }
    }
}
