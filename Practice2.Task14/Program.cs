//Создайте и реализуйте метод, который принимает на вход размер массива n и
//возвращает пустой массив указанного размера. Вызовите метод в методе Main
//и заполните его полученный массив. Содержимое массива выведите на экран
using System;
class Task14
{
    static void Main()
    {
        var array = Task14.Array(10);
        var rnd = new Random();

        for(int i = 0; i < 10; i++)
            array[i] = rnd.Next(0, 10);
        foreach (int i in array)
        {
            Console.Write(i);
            Console.Write(" ");
        }

        Console.ReadLine();
    }
    static int[] Array (int n)
    { 
        return new int[n];
    }
}