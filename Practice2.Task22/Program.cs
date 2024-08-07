﻿//Напишите игру Угадай число. Программа случайно генерирует число от 1 до
//100, а пользователь пытается угадать это число. При успешной догадке
//выводите поздравление пользователя. Также покажите количество попыток,
//принятых пользователем.
//a. Сделайте ограничение по попыткам. Например, если попыток больше 10,
//то пользователь проиграл
//b. Сделайте подсказки для пользователя. Если предположенное число
//больше загаданного, то писать в консоль об этом. Аналогично и для
//меньшего числа.
class Task22
{
    static void Main()
    {
        var rnd = new Random();
        int variable = rnd.Next(1, 100);

        Console.WriteLine("Угадай число от 1 до 100");
        Console.WriteLine("Вводите число, у вас только 10 попыток");
        int i = int.Parse(Console.ReadLine());
        int j = 1;

        while (i != variable)
        {
            if (i < variable)
                Console.WriteLine("Загаданное число больше");
            if (i > variable)
                Console.WriteLine("Загаданное число меньше");

            i = int.Parse(Console.ReadLine());
            j++;

            if (j == 10)
            {
                Console.WriteLine("попытки кончились, вы проиграли");
                Console.ReadLine();
                return;
            }    
        }
        Console.WriteLine("Поздравляем, вы угадали!");

        Console.ReadLine();
    }
}