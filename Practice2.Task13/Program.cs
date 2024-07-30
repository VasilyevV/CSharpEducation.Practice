//Напишите метод, который создаёт двумерный массив (не зубчатый). Размеры
//массива передавайте через аргументы метода. Также напишите отдельный
//метод для вывода двумерного массива в виде матрицы на экран консоли.
//Массив заполните случайными числами.
using System;

class Task13
{
    static void Main(string[] args)
    {
        int size  = int.Parse(args[0]);
        int[,] matrix = new int[size,size];
        var rnd = new Random();

        for(int i = 0; i < size; i++)
            for(int j = 0; j < size; j++)
                matrix[i,j] = rnd.Next(100, 999);
        
        Task13.Print(matrix);

        Console.ReadLine();
    }
    static void Print(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j]);
                Console.Write(" ");
            }
            Console.WriteLine();
        }
        return;
    }
}