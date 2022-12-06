using System.Collections;
using System.IO;
using static System.Net.Mime.MediaTypeNames;

namespace Practic9
{
    class main
    {
        static void Main()
        {
            SortedList<char,  ArrayList > Tenseses= new SortedList<char, ArrayList>();// идея такова: у нас будет коллекция(ключ-значение)
                                                                                      // где ключ - это буква, в которой начинается предложение
                                                                                      // значение - это другая коллекция, содержащия все предложения, начинающиеся на эту букву.
            Console.OutputEncoding = System.Text.Encoding.UTF8;// настраиваем кодировку для вывода, иначе будут выводиться непоянтные символы, можешь убрать проверить)
            string path = @"C:\\Users\\magic\\Desktop\\Practic6\\Practic6\\input.txt";// путь к файлу, откуда мы считываем
            string Text="";
            using (StreamReader reader = new StreamReader(path))
            {
                Text = reader.ReadToEnd()// весь текст теперь храниться в этой переменной как одна большая строка
                    .Replace(Environment.NewLine, "")// Если в тексте переносится строка, то удалим этот перенос
                    .Replace(". ", ".");// Удаляем так же пробелы полсе точки
            }
            string[] TentensesFromFile = Text.Split(new string[] { "." }, StringSplitOptions.RemoveEmptyEntries);// преобразуем весь текст в массив, где каждый индекс это отдельное приложение
            for(int i = 0; i < TentensesFromFile.Length; i++)// здесь ма записываем наши предложения в коллекцию
            {
                char key = TentensesFromFile[i][0];// Ключ для записи в коллекцию предложений - это первая буква предложения
                if (!Tenseses.ContainsKey(key))// Если на .. букву добавляем предолжение впервые, то надо его вначале заполнить пустым массивом
                {
                    Tenseses.Add(key, new ArrayList());// заполняем пустым массивов
                }
                Tenseses[key].Add(TentensesFromFile[i] + ".");// Добавляем наше предложение
                
            }
            foreach (var outer in Tenseses.Keys)// По очереди будет по каким буквам у нас сгрупированы предложения
            {
                foreach(var er in Tenseses[outer])
                {
                    Console.WriteLine(er);// С каждой группы по очереди будет выводить предложения
                }
            }

        }
    }
}