using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstructorsKT4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            Book book2 = new Book("Мастер и Маргарита", "Михаил Булгаков", 1967);
            Book book3 = new Book("Война и мир", "Лев Толстой");
            Book book4 = new Book("Преступление и наказание", "Фёдор Достоевский", 1866);

            book1.DisplayInfo();
            book2.DisplayInfo();
            book3.DisplayInfo();
            book4.DisplayInfo();
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int Year { get; set; }

        public Book()
        {
            Title = "Без названия";
            Author = "Неизвестно";
            Year = 0;
        }
        public Book(string title, string author, int year)
        {
            Title = title;
            Author = author;
            Year = year;
        }
        public Book(string title, string author) : this(title, author, 2024) { }
        public void DisplayInfo()
        {
            Console.WriteLine($"Название: {Title}, Автор: {Author}, Год: {Year}");
        }
    }
}
