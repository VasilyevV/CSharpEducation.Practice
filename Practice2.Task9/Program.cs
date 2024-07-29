//Напишите метод, который создаёт массив целых чисел и возвращает его.
//Размер массива нужно передавать в качестве аргумента. Вдобавок напишите
//метод, который выводит переданный массив на экран консоли.
using System;
class Task9
{
    static void Main(string[] args)
    {
        int a = int.Parse(args[0]);
        var Mas = Task9.Init(a);
        Task9.Print(Mas);

        Console.ReadLine();
    }

    static int[] Init (int s)
    {
        int[] ints = new int[s];
        var rnd = new Random();
        for (int i = 0; i < s; i++)
            ints[i] = rnd.Next();
        return ints;
    }
    static void Print(int[] a)
    {
        for (int i = 0; i < a.Length; i++)
        {
            Console.Write(a[i]);
            Console.WriteLine(" ");
        }
        return;
    }
}    