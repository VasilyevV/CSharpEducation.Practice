/*Нарисуйте прямоугольный треугольник звёздочками. Чтобы высоту
треугольника можно было задавать программно. Пример:
a. 
*
**
***
****
и тд
b. 
*
**
***
****
и тд
c. Дайте возможность задавать символ для отрисовки программно. Т.е.
вместо звёздочки может быть любой символ.
*/
using System;
class Task4
{
    static void Main()
    {
        Console.WriteLine("Ведите высоту треугольника:");
        int h = int.Parse(Console.ReadLine());


        for (int i = 1; i <= h; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
        

        for (int i = 1; i <= h; i++)
        {
            for (int j = 0; j < h - i; j++)
                Console.Write(" ");
            for (int j = 1; j <= i; j++)
                Console.Write("*");
            Console.WriteLine();
        }
        
        Console.WriteLine("Введите символ: ");
        char s = char.Parse(Console.ReadLine());

        for (int i = 1; i <= h; i++)
        {
            for (int j = 1; j <= i; j++)
                Console.Write(s);
            Console.WriteLine();
        }


        for (int i = 1; i <= h; i++)
        {
            for (int j = 0; j < h - i; j++)
                Console.Write(" ");
            for (int j = 1; j <= i; j++)
                Console.Write(s);
            Console.WriteLine();
        }

            Console.ReadLine();
    }
}