using Asp.NetHw8.Interfaces;
using Asp.NetHw8.Models;

namespace Asp.NetHw8.Repositories
{
    public class BookRepository : IBookService
    {
        private readonly List<Book> _books = new List<Book>();

        public BookRepository()
        {
            _books.Add(new Book("CLR via C#", "Jeffrey Richter", "Programming", 2012));
            _books.Add(new Book("Clean Code", "Robert C. Martin", "Software Engineering", 2008));
            _books.Add(new Book("Design Patterns", "Erich Gamma", "Software Engineering", 1994));
            _books.Add(new Book("C# 12 in a Nutshell", "Joseph Albahari", "Programming", 2023));
            _books.Add(new Book("Domain-Driven Design", "Eric Evans", "Architecture", 2003));
        }

        public IEnumerable<Book> GetAll() => _books;
        public void Add(Book book) => _books.Add(book);
    }
}