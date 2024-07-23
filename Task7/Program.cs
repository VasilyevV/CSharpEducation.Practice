using System;

class Task7
{
    static void Main()
    {
        int a = 10; int b = 25; int c = 30;
        Console.WriteLine("Длина катета а = {0}, длина катета b = {1}", a, b);
        Console.WriteLine("Длина гипотинузы c = {0}", A(a, b));
        Console.WriteLine("Длина катета а = {0}, длина гипотинузы с = {1}", a, c);
        Console.WriteLine("Длина катета b = {0}", B(a, c));
        Console.ReadLine();
    }
    static int A(int a, int b)
    {
        double c = Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
        return (int)Math.Round(c);
    }
    static int B(int a, int c) 
    {
        double b = Math.Sqrt(Math.Pow(c, 2) - Math.Pow(a, 2));
        return (int)Math.Round(b);
    }
}