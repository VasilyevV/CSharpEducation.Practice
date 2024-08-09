//Создай класс "Автомобиль" с полем "Марка". Напиши метод, который будет
//принимать объект класса "Автомобиль" и выводить информацию о марке автомобиля в консоль.
using System.Runtime.InteropServices;

namespace Practice3.Task10
{
    class Program
    {
        static void Print (Auto auto)
        {
            Console.WriteLine (auto.brand);
        }

        static void Main(string[] args) 
        {
            Auto zhiga = new Auto ();
            zhiga.brand = "VAZ";

            Print (zhiga);
            Console.ReadLine();
        }
    }
    internal class Auto
    {
        public string brand;
    }
}