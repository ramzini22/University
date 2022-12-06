using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Практическая_работа_10;
class main
{
    public static void Main()// 6 Продемонстрировать работу класса, построенного по принципу «включение-делегирование». Для этого в методе Main вывести меню для выбора одного из возможных действий:
    {
        Console.OutputEncoding = System.Text.Encoding.UTF8;
        CollectionOfStudent collectionOfStudent = new CollectionOfStudent();
        string d0;
        do
        {
            Console.WriteLine(
                "\n1) Добавить в коллекцию объект\n"+
                "2) Удалить объект из коллекции\n" +
                "3) Вывести сведения по имеющимся в коллекции объектам\n" +
                "4) Внести изменения в характеристики объекта коллекции\n" +
                "5) Выход из программы\n"
            );
            d0=Console.ReadLine();
            switch (d0)
            {
                case "1":
                    collectionOfStudent.AddStudent();
                    break;
                case "2":
                    collectionOfStudent.DeleteStudent();
                    break;
                case "3":
                    collectionOfStudent.GetAllStudents();
                    break;
                case "4":
                    collectionOfStudent.ChangeStudent();
                    break;
                case "5":
                    break;
                default:
                    break;
            }
        } while (d0!="5");
    }
}