namespace Practice5.Task1
{
    class Animal
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public Animal(string name, int age) 
        {
            this.Name = name;
            this.Age = age;
        } 
        public void Eat()
        {
            Console.WriteLine("Animal is eating");
        }
        public void Sleep()
        {
            Console.WriteLine("Animal is sleeping");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("Some generic animal sound");
        }
    }
    class Cat : Animal 
    {
        public Cat(string name, int age) : base(name, age)
        {
            Console.WriteLine($"Создан кот {name}, возраст {age}");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Meow!");
        }
    }
    class Dog : Animal
    {
        public Dog(string name, int age) : base(name, age)
        {
            Console.WriteLine($"Создан пес {name}, возраст {age}");
        }
        public override void MakeSound()
        {
            Console.WriteLine("Woof!");
        }
    }
    class Parrot : Animal
    {
        public string Color { get; set;}
        public Parrot(string name, int age, string color) : base (name, age) 
        {
            this.Color = color;
        }
        public new void MakeSound(string words) 
        {
            Console.WriteLine(words);
        }
    }
    class Program
    {
        static void Main()
        {
            var cat = new Cat("cat", 5);
            var dog = new Dog("dog", 9);
            var parrot = new Parrot("parrot", 6, "multicolor");

            cat.MakeSound();
            dog.MakeSound();
            parrot.MakeSound($"{parrot.Name} is smart!");
           
        }
    }
}