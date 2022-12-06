
using System.Collections;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace Practic9
{
    class main
    {
        static void Main()
        {

            string Surname="";// фамилия у кого самый большой стаж
            int OldAge = 0;// самый большой стаж
            SortedList<string, SortedList> TeachersCollection = new SortedList<string, SortedList>();// чтобы данные были сами отсортированы, мы используем эту коллекцию, и чтобы фамилии учителей тоже были отсортированы, фамилии мы тоже хоаним в коллекции
            string pathRead = @"C:\\Users\\magic\\Desktop\\Лови удачу\\Практическая_6-2\\Practic6\\Practic6\\input.txt";// путь к файлу, откуда мы считываем
            string pathWrite = @"C:\\Users\\magic\\Desktop\\Лови удачу\\Практическая_6-2\\Practic6\\Practic6\\output.txt";// путь к файлу, куда мы записываем
            string Text = "";
            using (StreamReader reader = new StreamReader(pathRead))
            {
                Text = reader.ReadToEnd()// весь текст теперь храниться в этой переменной как одна большая строка
                    .Replace(Environment.NewLine, " ");// Если в тексте переносится строка, то заменим этот перенос на пробел
            }
            string[] TeachersArray = Text.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);// преобразуем весь текст в массив, где каждая ячейка это одно слово
            for(int i = 0; i < TeachersArray.Length; i+=3)
            {
                string key = TeachersArray[i];// в этом массиве каждое 1-е слово это дисциплина, 2-е фамилия, 3-е стаж
                int age;
                int.TryParse(TeachersArray[i+2], out age);//преобразуем строку в число
                if (age > OldAge)// вычисляем самый юольшой стаж
                {
                    OldAge = age;
                    Surname = TeachersArray[i + 1];
                }
            if (!TeachersCollection.ContainsKey(key))// если дисциплина впервые объявлена, добавляем пустйю коллекцию с этой дисциплиной
                {
                    TeachersCollection.Add(key, new SortedList());
                }
                TeachersCollection[key].Add(TeachersArray[i+1], TeachersArray[i+2]);// добавляем фамилию учителя и стаж
            }

            StreamWriter print = new StreamWriter(pathWrite, false);// делаем для того, чтобы в файле дл явывода стереть прошлые данные
            print.Write("");// стираем все данные
            print.Close();


            foreach (var outer in TeachersCollection.Keys)// По очереди будет по каким предметам у нас сгрупированы учителя
            {
                foreach(var teacher in TeachersCollection[outer].Keys)// по очереди выводит каждого преподователя
                {
                    File.AppendAllText(pathWrite, outer + " " + teacher + " " + TeachersCollection[outer][teacher]+"\n", Encoding.UTF8);// записываем в файл дисциплину, фамилию и стаж
                }
            }
            File.AppendAllText(pathWrite, "Наибольший стаж: "+Surname+" "+ OldAge, Encoding.UTF8);// записываем в файл фамилию и стаж у того учителя, у которой стаж больше всех
        }
    }
}