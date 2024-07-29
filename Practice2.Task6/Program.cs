//Введите с клавиатуры строку произвольной длины и подсчитайте процент вхождения заданного символа в строку.
//a. строка и символ указываются программно
//b. строка и символ указываются пользователем в консоли
//c. строка и символ указываются через аргументы командной строки
using System;
class Task6
{
    static void Main(string[] args )
    {
        string s = "Духовной жаждою томим, в пустыне мрачной я влачился, и шестикрылый серафим на перепутье мне явился.";
        char c = 'а';
        Console.WriteLine("Строка: " + s);
        Console.WriteLine("Симовол: " + c);
        Console.Write("Процент вхождения заданного символа в строку: ");

        double k = 0;
        for(int i = 0; i < s.Length; i++)
            if (s[i] == c)
                k++;
        double f = k / s.Length * 100;
        Console.Write(Math.Floor(f));
        Console.WriteLine("%");

        Console.WriteLine("Введите строку и символ:");
        string s1 = Console.ReadLine();
        char c1 = char.Parse(Console.ReadLine());
        Console.Write("Процент вхождения заданного символа в строку: ");
        k = 0;
        for (int i = 0; i < s1.Length; i++)
            if (s1[i] == c1)
                k++;
        double f1 = k / s1.Length * 100;
        Console.Write(Math.Floor(f1));
        Console.WriteLine("%");

        Console.WriteLine("Строка: " + args[0]);
        Console.WriteLine("Символ: " + args[1]);
        Console.Write("Процент вхождения заданного символа в строку: ");
        k = 0;
        char c2 = char.Parse(args[1]);
        for (int i = 0; i < args[0].Length; i++)
            if (args[0][i] == c2)
                k++;
        double f2 = k / args[0].Length * 100;
        Console.Write(Math.Floor(f2));
        Console.WriteLine("%");

        Console.ReadLine();
    }
}