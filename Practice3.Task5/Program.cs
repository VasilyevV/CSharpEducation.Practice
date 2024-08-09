//Создай класс "Книга" с полями "Название" и "Автор". Реализуй два конструктора:
//один с параметрами для инициализации полей, другой без параметров, который
//будет устанавливать значения по умолчанию. Расширь класс "Книга" из
//предыдущего задания, добавив поле "Год издания". Реализуй цепочку
//конструкторов так, чтобы можно было создавать объекты класса "Книга" с
//указанием только названия, названия и автора, или всех трех полей.

namespace Practice3.Task5
{
    internal class Book
    {
        public string name;
        public string autor;
        public int publyear;

        public Book(string name)
        {
            this.name = name;
        }
        public Book(string name, string autor)
        {
            this.name = name;
            this.autor = autor;
        }
        public Book(string name, string autor, int publyear)
        {
            this.name = name;
            this.autor = autor;
            this.publyear = publyear;
        }
        public Book() : this("пусто", "пусто", 0)
        { }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            Console.WriteLine(book.name);
            Console.WriteLine(book.autor);
            Console.WriteLine(book.publyear);

            book = new Book("kdjfklgj");
            Console.WriteLine(book.name);

            book = new Book("gsdfg", "sdfg");
            Console.WriteLine(book.name);
            Console.WriteLine(book.autor);

            book = new Book("shgfhdfg", "gdsfg", 1954);
            Console.WriteLine(book.name);
            Console.WriteLine(book.autor);
            Console.WriteLine(book.publyear);
        }
    }
}