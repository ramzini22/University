using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Практическая_работа_10
{
    internal class CollectionOfStudent// 4 Создать класс, содержащий коллекции производных от базового абстрактного класса объектов.
    {
        Student[] students = new Student[100];
        private int size = 0;
        // 5 Описать в классе, построенном по принципу «включение-делегирование»,  следующие методы:
        public void AddStudent() // 5 добавления в коллекцию новых объектов,
        {
            Console.Write(
                "1) Бакалавриат\n"+
                "2) Магистр\n" +
                "3) Аспирант\n");
            string choice = Console.ReadLine();
            Console.Write("Введите имя(или просто нажмите Enter): ");
            string name = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    if(name!="")
                        students[size]=new Bakalavriat(name);
                    else
                        students[size] = new Bakalavriat();
                    break;
                case "2":
                    if (name != "")
                        students[size] = new Magistr(name);
                    else
                        students[size] = new Magistr();
                    break;
                case "3":
                    if (name != "")
                        students[size] = new Aspirant(name);
                    else
                        students[size] = new Aspirant();
                    break;
            }
            size++;

        }
        public void ChangeStudent()// 5 изменения свойств и полей имеющихся объектов по номеру объекта в коллекции;

        {
            Console.Write("Введите индекс студента: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите новую форму обучения: ");
            string choice2 = Console.ReadLine();
            students[choice].SetName(choice2);
        }
        public void DeleteStudent()// 5 удаление из коллекции объектов по его номеру
        {
            Console.Write("Введите индекс студента: ");
            int choice = int.Parse(Console.ReadLine());
            students[choice] = null;
            size--;

        }
        public void GetAllStudents()// 5 вывода информации, об имеющихся в коллекции объектах.
        {
            if (size != 0)
                for (int i = 0; i < 100; i++)
                {
                    if (students[i] != null)
                        Console.WriteLine(i + ") форма обучения: " + students[i].GetName() + "; год начала учебы: " + students[i].GetYearBegin());
                }
            else Console.WriteLine("Коллекция не содержит объектов");
        }
    }
}
