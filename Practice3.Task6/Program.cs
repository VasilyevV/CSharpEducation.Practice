//Создай структуру "Точка" с полями "X" и "Y" типа int. Напиши метод, который будет
//принимать две точки и возвращать расстояние между ними.

namespace Practice3.Task6
{
    internal struct Point
    {
        public int x;
        public int y;
        public int Distance( int x, int y)
        { 
           return y - x;
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var point = new Point();
            Console.WriteLine(point.Distance(10, 50));

            Console.ReadLine();
        }
    }
}