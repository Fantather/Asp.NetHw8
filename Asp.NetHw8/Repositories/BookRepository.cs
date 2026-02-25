using Asp.NetHw8.Interfaces;
using Asp.NetHw8.Models;

namespace Asp.NetHw8.Repositories
{
    public class BookRepository : IBookService
    {
        private readonly List<Book> _books = new List<Book>();

        public BookRepository()
        {
            _books.Add(new Book("CLR via C#", "Jeffrey Richter", "Programming", 2012, Enumerable.Empty<string>()));
            _books.Add(new Book("Clean Code", "Robert C. Martin", "Software Engineering", 2008, Enumerable.Empty<string>()));
            _books.Add(new Book("Design Patterns", "Erich Gamma", "Software Engineering", 1994, Enumerable.Empty<string>()));
            _books.Add(new Book("C# 12 in a Nutshell", "Joseph Albahari", "Programming", 2023, Enumerable.Empty<string>()));
            _books.Add(new Book("Domain-Driven Design", "Eric Evans", "Architecture", 2003, Enumerable.Empty<string>()));
            _books.Add(new Book("Pro ASP.NET Core 7", "Adam Freeman", "Programming", 2022, Enumerable.Empty<string>()));
            _books.Add(new Book("Refactoring", "Martin Fowler", "Software Engineering", 1999, Enumerable.Empty<string>()));
            _books.Add(new Book("The Pragmatic Programmer", "Andrew Hunt", "Software Engineering", 1999, Enumerable.Empty<string>()));
            _books.Add(new Book("Concurrency in C# Cookbook", "Stephen Cleary", "Programming", 2019, Enumerable.Empty<string>()));
            _books.Add(new Book("Code Complete", "Steve McConnell", "Software Engineering", 2004, Enumerable.Empty<string>()));
            _books.Add(new Book("Patterns of Enterprise Application Architecture", "Martin Fowler", "Architecture", 2002, Enumerable.Empty<string>()));
            _books.Add(new Book("Head First Design Patterns", "Eric Freeman", "Software Engineering", 2004, Enumerable.Empty<string>()));
        }

        public IEnumerable<Book> GetAll() => _books;
        public void Add(Book book) => _books.Add(book);

        public Book? GetById(Guid targetId) => _books.Find(book => book.Id == targetId);
    }
}