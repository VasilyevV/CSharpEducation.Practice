// Создай класс "Студент" с полями "Имя" и "Возраст". Напиши метод, который будет
//принимать объект класса "Студент" и изменять его имя на "Аноним".
namespace Practice3.Task9
{
    class Program
    {
        static Student MakeAnonymous(Student student)
        {
            student.name = "Anonymous";
            return student;
        }
        static void Main(string[] args) 
        {
            Student student = new Student();
            student.age = 35;
            student.name = "Jack";
            Console.WriteLine($"Имя: {student.name}  Возраст: {student.age}");

            MakeAnonymous(student);
            Console.WriteLine($"Имя: {student.name}  Возраст: {student.age}");

            Console.ReadLine();
        }
    }
    internal class Student
    {
        public string name;
        public int age;
    }
}