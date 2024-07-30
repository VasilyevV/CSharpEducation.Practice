//Создайте и реализуйте метод, который будет принимать два числа и менять их
//значения местами. Вызовите метод в Main
using System;
class Task17
{
    static void Main()
    {
        var rnd = new Random();
        int a = rnd.Next(1, 100);
        int b = rnd.Next(1, 100);
        Console.WriteLine($"{a} {b}");
        Task17.Replace( ref a, ref b);
        Console.WriteLine($"{a} {b}");
        Console.ReadLine();
    }
    static void Replace(ref int a, ref int b)
    {
        int t = a;
        a = b;
        b = t;
    }
}