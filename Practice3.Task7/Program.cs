//Создай перечисление "Месяцы" с элементами, представляющими названия
//месяцев года. Напиши метод, который будет принимать месяц и возвращать
//количество дней в этом месяце.
using System.ComponentModel.Design;

namespace Practice3.Task7
{
    class Program
    {
        enum Month
        {
            January,
            February,
            March,
            April,
            May,
            June,
            July,
            August,
            September,
            October,
            November,
            December
        }

        static int Days (Month month)
        {
            int i = (int)month + 1;
            var number = new List<int> {1, 3, 5, 7, 8, 10, 12};

                if (number.Contains(i))
                    return 31;
                else if (i == 2)
                    return 28;
                else
                    return 30;           
        }
        static void Main()
        {
            var days = Days (Month.February);
            Console.WriteLine (days);

            Console.ReadLine();
        }
    }
}