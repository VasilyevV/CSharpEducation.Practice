// Создайте одномерный массив целых чисел произвольной длины и заполните
//случайными числами от 1 до 100. Выведите на экран разницу максимального и
//минимального значений в нём.
using System;
class Task19
{
    static void Main()
    {
        var rnd = new Random();
        int[] ints = new int[rnd.Next(10, 50)];

        for (int i = 0; i < ints.Length; i++)
            ints[i] = rnd.Next(1, 100);
        foreach (int i in ints)
            Console.Write($"{i} ");
        Console.WriteLine();

        int max = ints.Max();//простой вариант
        int min = ints.Min();
        Console.WriteLine($"{max}   {min}\nразница максимального и минимального значений: {max - min}");
        Console.ReadLine();

        max = ints[0];
        for (int i = 1; i < ints.Length; i++)
            if (ints[i] > max)
                max = ints[i];
        min = ints[0];
        for (int i = 1; i < ints.Length; i++)
            if (ints[i] < min)
                min = ints[i];
        Console.WriteLine($"{max}   {min}\nразница максимального и минимального значений: {max - min}");
        Console.ReadLine();
    }
}