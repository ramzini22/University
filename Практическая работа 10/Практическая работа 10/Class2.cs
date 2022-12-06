using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_10
{
    internal class Bakalavriat : Student// 4
    {
        private string name;//5
        public string GetName() => name;// 5
        public Bakalavriat() => name = "Бакалавриат";// 6
        public Bakalavriat(string name) => this.name = name;// 6
        public override int GetYearBegin() => 2023;// 7


    }
}
