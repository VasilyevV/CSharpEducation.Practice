//Напишите программу, в которой создаётся массив строк, который заполняется
//пользователем через консоль. Затем этот массив должен быть выведен на
//экран консоли.
using System;
class Task12
{
    static void Main(string[] args)
    {
        string[] strings = new string[5];
        for (int i = 0; i < 5; i++)
            strings[i] = Console.ReadLine();
        foreach (string s in strings)
            Console.WriteLine(s);

        Console.ReadLine();
    }
}