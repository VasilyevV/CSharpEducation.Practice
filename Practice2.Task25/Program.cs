// Создайте перечисление (enum) для дней недели. Напишите программу, которая
//считывает ввод пользователя и в зависимости от его ввода (число от 1 до 7)
//будет выводиться на экран консоли соответствующий день недели.
class Task25
{
    enum Days
    {
        Понедельник = 1,
        Вторник,
        Среда,
        Четверг,
        Пятница,
        Суббота,
        Воскресенье
    }
    static void Main()
    {
        Console.Write("Введите номер дня недели: ");
        int i = int.Parse(Console.ReadLine());

        foreach (Days d in Enum.GetValues(typeof(Days)))
            if (i == (int)d)
                Console.WriteLine(d);

        Console.ReadLine();
    }
}