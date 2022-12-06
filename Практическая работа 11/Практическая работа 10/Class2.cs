using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_10
{
    internal class Bakalavriat : Student
    {
        public Bakalavriat() => name = "Бакалавриат";
        public Bakalavriat(string name) => this.name = name;

        public override string GetName() { return name; }
        public override void SetName(string name) => this.name = name;

        public override int GetYearBegin() => 2023;
        public override int GetYearEnd()// 3 В производных классах переопределить наследуемый метод изменения свойств и полей класса.
        {
            return GetYearBegin() + 4;
        }

    }
}
