// Создай класс "Книга" с полями "Название" и "Автор". Напиши метод, который будет
//принимать объект класса "Книга" и возвращать информацию о книге в виде строки.
namespace Practice3.Task11
{
    class Program
    {
        static string Info (Book book)
        {
            string info = "Название: " + book.title + "   Автор: " + book.author;
            return info;
        }
        static void Main()
        {
            Book book1 = new Book();
            book1.title = "Clr Via C#";
            book1.author = "Джеффри Рихтер";

            Console.WriteLine(Info(book1));
            Console.ReadLine();
        }
    }
    class Book
    {
        public string title;
        public string author;
    }
}