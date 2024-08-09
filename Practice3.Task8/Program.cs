//Cоздай структуру "Прямоугольник" с полями "Ширина" и "Высота" типа double.
//Напиши метод, который будет вычислять площадь прямоугольника
namespace Practice3.Task8
{
    class Program
    {
        internal struct Rectangle
        {
            public double height;
            public double width;

            public double Square()
            {
                return height* width;
            }
        }
        static void Main()
        {
            Rectangle rect = new Rectangle();
            rect.height = 10;
            rect.width = 10;

            Console.WriteLine($"Площадь прямоугольника = {rect.Square()}");
            Console.ReadLine();
        }
    }
}