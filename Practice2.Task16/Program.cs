//Создайте и реализуйте метод, который будет принимать число по ссылке (ref) и
//менять его знак на противоположный. Метод должен принимать один аргумент и
//не возвращать ничего.
using System;
class Task16
{
    static void Main()
    {
        int a = 56;
        Console.WriteLine(a);
        Task16.Invert(ref a);
        Console.WriteLine(a);

        Console.ReadLine();
    }
    static void Invert(ref int a)
    {
        a = -a;
    }
}
