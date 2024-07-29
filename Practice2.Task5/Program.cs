//программа для сравнения двух целых чисел. Ввод осуществляйте через консоль.
using System;
class Task5
{
    static void Main()
    {
        Console.WriteLine("Введите 2 целых числа:");
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());

        if (a == b)
            Console.WriteLine("Эти числа равны");
        else if (a > b)
            Console.WriteLine("Первой число больше второго");
        else
            Console.WriteLine("Второе число больше первого");

        Console.ReadLine();
    }
}