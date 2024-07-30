//Создайте и реализуйте метод, который принимает на вход массив и
//инвертирует его. Вызовите его в методе Main. Исходный массив задайте сами.
//Инвертированный массив выведите на экран консоли.
using System;
class Task15
{
    static void Main()
    {
        int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };

        foreach (int i in array)
        {
            Console.Write(i);
            Console.Write(" ");
        }
        array = Task15.RevArr(array);
        Console.WriteLine();

        foreach (int i in array)
        {
            Console.Write(i);
            Console.Write(" ");
        }

        Console.ReadLine();
    }
    static int[] RevArr(int[] arr)
    {
        for (int i = 0, j = arr.Length - 1; i < j; i++, j--)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }
        return arr;
    }
}