using lb8.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8.Classes
{
    public class JobType : IJobType
    {
        public string Name { get; set; }
        public decimal BasePay { get; set; }
        public decimal Bonus { get; set; }
    }
}
