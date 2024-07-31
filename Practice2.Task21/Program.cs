//Напишите игру Угадай число. Программа случайно генерирует число от 1 до
//100, а пользователь пытается угадать это число. При успешной догадке
//выводите поздравление пользователя.
class Task21
{
    static void Main()
    {
        var rnd = new Random();
        int variable = rnd.Next(1, 100);

        Console.WriteLine("Угадай число от 1 до 100");
        Console.WriteLine("Вводите число");
        int i = int.Parse(Console.ReadLine());

        while (i != variable)
        {
            i = int.Parse(Console.ReadLine());
        }
        Console.WriteLine("Поздравляем, вы угадали!");

        Console.ReadLine();
    }
}