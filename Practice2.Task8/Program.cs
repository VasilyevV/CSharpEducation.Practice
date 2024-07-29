// Составить алгоритм увеличения всех трех, введенных с клавиатуры,
//переменных на 5, если среди них есть хотя бы две равные. В противном случае
//выдать ответ «равных нет».

using System;
class Task8
{
    static void Main()
    {
        int a, b, c;
        Console.WriteLine("Введите 3 переменные:");
        a = int.Parse(Console.ReadLine());
        b = int.Parse(Console.ReadLine());
        c = int.Parse(Console.ReadLine());

        if (a == b)
        {
            a = a + 5; b = b + 5; c = c + 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        else if (a == c)
        {
            a = a + 5; b = b + 5; c = c + 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        else if (b == c)
        {
            a = a + 5; b = b + 5; c = c + 5;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
        else
            Console.WriteLine("равных нет");

        Console.ReadLine();
    }
}