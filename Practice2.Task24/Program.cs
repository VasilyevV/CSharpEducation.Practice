//  Создайте перечисление (enum) для дней недели. Напишите программу, которая
//выводит на экран дни недели по названиям
class Task24
{
    enum Days
    {
        Понедельник,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    static void Main()
    {
        foreach(Days d in Enum.GetValues(typeof(Days)))
            Console.WriteLine(d);

        Console.ReadLine();
    }
}