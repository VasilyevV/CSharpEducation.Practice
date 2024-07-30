// Создайте и реализуйте метод, который будет принимать массив на вход убирать
//из него отрицательные числа и возвращать новый изменённый массив. Через
//out параметр возвращать количество удалённых символов.
using System;
class Task18
{
    static void Main()
    {
        var rnd = new Random();
        int[] ints = new int[10];
        for(int i = 0; i < 10; i++) 
            ints[i] = rnd.Next(-100, 100);
        int index = 0;

        var ints2 = Task18.DelNeg(ints, out index);

        for (int i = 0; i < ints.Length; i++)
            Console.Write($"{ints[i]} ");
        Console.WriteLine();
        for (int i = 0; i < ints2.Length; i++)
            Console.Write($"{ints2[i]} ");
        Console.WriteLine();
        Console.WriteLine(index);

        Console.ReadLine();
    }

    static int[] DelNeg(int[] array, out int index)
    {
        index = 0;
        foreach (int i in array) 
        {
            if (i < 0)
                index++;
        }
        int[] newarr = new int[array.Length - index];

        for(int i = 0, j = 0; i < array.Length; i++, j++)
        {
            if (array[i] >= 0)
                newarr[j] = array[i];
            else
                j--;
        }
        return newarr;
    }
}