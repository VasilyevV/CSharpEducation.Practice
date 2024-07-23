using System;

class Task6
{
    static void Main()
    {
        var rnd = new Random();
        const double pi = Math.PI;
        int r = rnd.Next(0, 100);
        double S = pi*Math.Pow(r,2.0);
        Console.WriteLine("S = {0}", S);
        Console.ReadLine();
    }
}