//Создай новый проект и подключи к нему библиотеку классов, созданную в предыдущем задании. Используй методы из класса "MathHelper" для выполнения простых математических операций в этом проекте.

namespace Practice4
{
    class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            int a = rnd.Next(1, 100);
            int b = rnd.Next(1, 100);

            Console.WriteLine($"{a}  {b}");
            Console.WriteLine(MathHelper.Add(a, b));
            Console.WriteLine(MathHelper.Sub(a, b));
            Console.WriteLine(MathHelper.Mult(a, b));
            Console.WriteLine(MathHelper.Divide(a, b));
        }
    }
}