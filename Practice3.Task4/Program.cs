//Создай класс "Книга" с полями "Название" и "Автор". Реализуй два конструктора:
//один с параметрами для инициализации полей, другой без параметров, который
//будет устанавливать значения по умолчанию.


using System.Security.Cryptography.X509Certificates;

namespace Practice3.Task4
{
    internal class Book
    {
        public string name;
        public string autor;

        public Book(string name, string autor)
        {
            this.name = name;
            this.autor = autor;
        }
        public Book()
        {
            this.name = "пусто";
            this.autor = "пусто";
        }
    }
    

    internal class Program
    {
        static void Main(string[] args)
        {
            var book = new Book();
            Console.WriteLine(book.name);
            Console.WriteLine(book.autor);
        }
    }
}