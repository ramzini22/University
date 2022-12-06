using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Практическая_работа_10
{
    internal class Student// 1
    {
        private int YearBegin;// 3
        public Student()// 2
        {
            YearBegin = 2022;
        }
        public Student(int year)// 2
        {
            YearBegin = year;
        }
        public virtual int GetYearBegin()// 3
        {
            return YearBegin;
        }
    }
}
