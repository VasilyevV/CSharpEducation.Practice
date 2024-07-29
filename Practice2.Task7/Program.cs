//Напишите программу, которая переводит строку в разные регистры
//a. в верхний регистр: f->F
//b.в нижний регистр: F->f
//c.делает заглавную букву в слове: привет->Привет
using System;
class Task7
{
    static void Main()
    {
        string s1 = "f";
        Console.WriteLine(s1);
        s1 = s1.ToUpper();
        Console.WriteLine(s1);

        string s2 = "F";
        Console.WriteLine(s2);
        s2 = s2.ToLower();
        Console.WriteLine(s2);

        string s3 = "привет";
        Console.WriteLine(s3);
        //s3[0] = char.ToUpper(s3[0]);
        Console.WriteLine(char.ToUpper(s3[0]) + s3.Substring(1, 5));
        Console.ReadLine();
    }
}