using System;
class Task2
    {
    static void Main() 
    {
        Console.WriteLine("Переводим:\nметры (а), километры (b), м/с (c), градусы (d)");
        var str = Console.ReadLine();

        if (str == "a")
        {
            Console.WriteLine("Переводим метры в километры, введите количество метров: ");
            string m = Console.ReadLine();
            int meters = int.Parse(m);
            Console.WriteLine($"Километров: {meters / 1000} километров");
        }

        else if (str == "b")
        {
            Console.WriteLine("Переводим километры в сантиметры, введите количество километров: ");
            string m = Console.ReadLine();
            int kmeters = int.Parse(m);
            Console.WriteLine($"Сантиметров: {kmeters * 100000} сантиметров");
        }

        else if (str == "c")
        {
            Console.WriteLine("Переводим м/с в км/ч, введите количество м/с: ");
            string m = Console.ReadLine();
            int ms = int.Parse(m);
            Console.WriteLine($"{ms * 1000/3600} км/ч");
        }

        else if(str == "d")
        {
            Console.WriteLine("Переводим градусы C в градусы F, введите количество градусов C: ");
            string m = Console.ReadLine();
            int с = int.Parse(m);
            Console.WriteLine($"Градусов {(с * 9/5) + 32} F");
        }
    }
}