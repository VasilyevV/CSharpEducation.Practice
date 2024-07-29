/// Напишите программу для вычисления выражения (а + b — f / а) + f * a * a — (a + b). Все переменные задаются пользователем. Учтите деление на 0.

using System;
class Task3
{
    static void Main()
    {
        int a, b, f;
        int[] ints = new int[3];

        Console.WriteLine("Вычисляем выражение вида (а + b — f / а) + f * a * a — (a + b). Введите коэффициенты a, b и f: ");
        for (int i = 0; i < 3; i++)
        {
            ints[i] = int.Parse(Console.ReadLine());
            if (ints[0] == 0)
            {
                Console.WriteLine("а не должно быть равно 0. Давай еще раз.");
                i--;
            }
        }
        float c = (ints[0] + ints[1] - ints[2] / ints[0]) +ints[2] * ints[0] * ints[0] - ints[0] + ints[1];
        Console.WriteLine($"(а + b — f / а) + f * a * a — (a + b) = {c}");
    }
}