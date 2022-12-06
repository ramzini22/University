using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_10
{
    abstract class Student// 1 определить базовый класс как абстрактный
    {
        public string name;
        public abstract string GetName();
        public abstract void SetName(string name);
        private int YearBegin;
        public Student()
        {
            YearBegin = 2022;
        }
        public Student(int year)
        {
            YearBegin = year;
        }
        public virtual int GetYearBegin()
        {
            return YearBegin;
        }
        public abstract int GetYearEnd();// 2 Давить в абстрактный класс дополнительный абстрактный метод для изменения значений свойств и/или полей класса.

    }
}
