using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Lab9
{
    internal class Set {
        private int[] Elements;// Поля 1
        private int Count = 0;// Поля 2
        public Set()
        {
            Console.Write("Введите кол-во элементов множества: ");
            Count = Convert.ToInt32(Console.ReadLine());
            Elements = new int[Count];
            Fill();
        }// Конструктор 1
        public Set(int[] elements)
        {
            Elements = elements;
            Count = elements.Length;
        }// Конструктор 2
        public static Set operator ++(Set set)// Перегрузка операций 1
        {
            for (int i = 0; i < set.Count; i++)
                set.Elements[i]++;
            return set;
        }
        public static Set operator +(Set set1, Set set2)// Перегрузка операций 2
        {
            for (int i = 0; i < set1.Count; i++)
                set1.Elements[i]+= set2.Elements[i];
            return set1;

        }
        public static Set operator *(Set set1, Set set2)// Перегрузка операций 3
        {
            for (int i = 0; i < set1.Count; i++)
                set1.Elements[i] *= set2.Elements[i];
            return set1;

        }
        public static Set operator /(Set set1, Set set2)// Перегрузка операций 4
        {
            for (int i = 0; i < set1.Count; i++)
            {
                if (set2.Elements[i] != 0) set1.Elements[i] /= set2.Elements[i];    // на 0 делить нельзя, поэтому делаем проверку
                else set2.Elements[i] = 0;
            }
            return set1;

        }
        public static bool operator < (Set set1, Set set2)// Перегрузка операций 5
        {
            return set1.Count<set2.Count;

        }
        public static bool operator >(Set set1, Set set2)// Перегрузка операций 5
        {
            return set1.Count > set2.Count;

        }
        public void Fill()// Методы 1
        {
            for (int i = 0; i < Count; i++)
            {
                Console.Write("Введите " + i + "-e число: ");
                Elements[i] = Convert.ToInt32(Console.ReadLine());
            }

        }
        public int IndexOf(int Value)// Методы 2
        {
            int index = -1;
            for(int i = 0; i < Count; i++)
            {
                if (Value == Elements[i])
                {
                    index = i;
                    break;
                }
            }

            return index;
        }
        public void ShowSet()// Методы 3
        {
            for(int i=0;i<Count;i++)
                Console.WriteLine(i + "-e число: " + Elements[i]);

        }
        public void Add(int NewElement)// Методы 4
        {
            Count++;
            Array.Resize(ref Elements, Count);
            Elements[Count-1] = NewElement;
        }
        public int GetElement(int index)// Индикатор для получения
        {
            if (index >= 0 && index < Count)
                return Elements[index];
            else return -1;
        }
        public bool SetElement(int index, int value)// Индикатор для записи
        {
            if (index >= 0 && index < Count) {
                Elements[index]=value;
                return true;
            }
            else return false;
        }

    }
}
