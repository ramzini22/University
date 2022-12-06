using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_10
{
    internal class Aspirant : Student// 4
    {
        private string name;// 5
        public string GetName() => name;// 5
        public Aspirant()=>name = "Аспирант";// 6
        public Aspirant(string name)=>this.name =name;// 6
        public override int GetYearBegin() => 2023;// 7

    }
}
