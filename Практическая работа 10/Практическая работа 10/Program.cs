using Практическая_работа_10;
class main
{
    public static void Main()
    {
        Student[] students = { new Bakalavriat(), new Magistr("Миша"), new Aspirant() };// 8
        Magistr newMagistr = new Magistr();// 9
        Aspirant newAspirant = new Aspirant("Коля");// 9
        Console.WriteLine(students[0].GetYearBegin());// 9


    }
}