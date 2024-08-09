//Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет
//выводить информацию о студенте в консоль.


namespace Practice3.Task1
{
    internal class Student
    {
        public string name = "Василий";
        public int age = 40;
        public void Getinfo()
        {
            Console.WriteLine($"Имя: {this.name}");
            Console.WriteLine($"Возраст: {this.age}");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            var student = new Student();
            student.Getinfo();
        }
    }
}