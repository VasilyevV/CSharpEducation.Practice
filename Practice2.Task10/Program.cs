//Напишите программу, в которой создаётся массив и выводится на экран
//консоли. Размер массива передавайте в качестве первого аргумента командной
//строки.
using System;
class Task10
{
    static void Main(string[] args)
    {
        var size = int.Parse(args[0]);
        int [] ints = new int[size];

        var rnd = new Random();
        for (int i = 0; i < size; i++)
            ints[i] = rnd.Next(0, 100);

        foreach (int i in ints)
            Console.WriteLine(i);
        Console.ReadLine();
        
    }
}