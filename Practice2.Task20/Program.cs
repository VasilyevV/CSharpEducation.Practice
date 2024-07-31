// Создайте двумерный массив целых чисел произвольной длины и заполните
//случайными числами от 1 до 100. Выведите на экран разницу максимального и
//минимального значений в каждой строке массива.
using System;
class Task20
{
    static void Main()
    {
        var rnd = new Random();
        int[,] ints = new int[10, 10];
        for(int i = 0; i < 10; i++)
            for (int j = 0; j < 10; j++)
                ints[i, j] = rnd.Next(1, 100);

        for (int i = 0; i < 10; i++)
        {
            for (int j = 0; j < 10; j++)
                Console.Write($"{ints[i, j]} ");
            Console.WriteLine();
        }

        for (int i = 0; i < 10; i++)
        {
            int max = ints[i, 0];
            int min = ints[i, 0];
            for (int j = 0; j < 10; j++)
            {
                if (ints[i,j] < min)
                    min = ints[i,j];
                if (ints[i, j] > max)
                    max = ints[i, j];
            }
            Console.WriteLine($"max = {max}  min = {min}, max - min = {max - min}");
        }

        Console.ReadLine();
    }
}