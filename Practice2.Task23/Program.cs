// Напишите программу для вычисления високосного года.
//a.год, номер которого кратен 400, — високосный;
//остальные годы, номер которых кратен 100, — невисокосные
//остальные годы, номер которых кратен 4, — високосный;
//все остальные годы — невисокосные.
class Task23
{
    static void Main()
    {
        Console.WriteLine("Введите год");
        decimal year = decimal.Parse(Console.ReadLine());

        if (year / 400 - Math.Truncate(year / 400) == 0)
            Console.WriteLine("Это високосный год");
        else if (year / 100 - Math.Truncate(year / 100) == 0)
            Console.WriteLine("Это невисокосный год");

        Console.ReadLine();

        if (year / 4 - Math.Truncate(year / 4) == 0)
            Console.WriteLine("Это високосный год");
        else
            Console.WriteLine("Это невисокосный год");

        Console.ReadLine();
    }
}