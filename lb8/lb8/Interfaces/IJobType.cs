using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb8.Interfaces
{
    // Интерфейс для работы с видами работ
    interface IJobType
    {
        string Name { get; set; }
        decimal BasePay { get; set; }
        decimal Bonus { get; set; }
    }
}
