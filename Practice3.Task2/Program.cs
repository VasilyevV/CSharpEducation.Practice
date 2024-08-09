//выводить информацию о студенте в консоль. Добавь в класс "Студент" свойство
//"Средний балл". Реализуй геттер и сеттер для этого свойства. Добавь проверку в
//сеттер, чтобы значение среднего балла было в диапазоне от 0 до 5.


namespace Practice3.Task1
{
    internal class Student
{
    public string name = "Василий";
    public int age = 40;
    public int average = 0  ;
    public int Average 
        {
            get
            {
                return average;   
            }
            set
            {
                if (value < 0 || value > 5)
                    Console.WriteLine("Неверное значениие оценки");
                else
                    average = value;
            }
        }
}

internal class Program
{
    static void Main(string[] args)
    {
        var student = new Student();
        Console.WriteLine(student.name);
        Console.WriteLine(student.age);
        student.Average = 6;
        Console.WriteLine(student.average);
    }
}
}