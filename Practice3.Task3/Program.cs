//Создай класс "Калькулятор" с методами для выполнения основных арифметических
//операций (сложение, вычитание, умножение, деление). Пусть эти методы
//принимают два числа и возвращают результат операции.


namespace Practice3.Task3
{
    internal class Calculator 
    {
        internal int Add (int a, int b)
        { return a + b; }
        internal int Sub (int a, int b)
        { return a - b; }
        internal int Mul (int a, int b)
        { return a * b; }
        internal double Div (int a, int b)
        { return a / b; }
    }

    
    internal class Program
    {
        static void Main(string[] args)
        {
            var calc = new Calculator();
            Console.WriteLine(calc.Mul(50, 5));
        }
    }
}