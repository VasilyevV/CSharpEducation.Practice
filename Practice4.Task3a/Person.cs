namespace Practice4.Task3a
{
    public class Person
    {
        private string name;
        private int age;
        public Person(string Name, int Age) 
        {
            this.name = Name;
            this.age = Age;
        }
        public void Print() 
        {
            Console.WriteLine($"Имя: {name}  Возраст: {age}");
        }
    }
}