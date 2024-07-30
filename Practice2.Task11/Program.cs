//Напишите программу, в которой создаётся массив и выводится на экран
//консоли.Размер массива передавайте в качестве первого аргумента командной
//строки. Число, которым будет заполняться массив передайте через второй
//аргумент командной строки.
using System;
class Task11
{
    static void Main(string[] args)
    {
        int size = int.Parse(args[0]);
        int dig = int.Parse(args[1]);
        int[] ints = new int[size];

        for (int i = 0; i < size; i++)
        {
            ints[i] = dig;
            Console.Write(ints[i]);
            Console.Write(" ");
        }

        Console.ReadLine();
    }
}