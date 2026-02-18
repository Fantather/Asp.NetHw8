namespace Asp.NetHw8.Models
{
    public class Book(string title, string author, string genre, int year, Guid? id = null)
    {
        public Guid Id { get; init; } = id ?? Guid.NewGuid();
        public string Title { get; set; } = title;
        public string Author { get; set; } = author;
        public string Genre { get; set; } = genre;
        public int Year { get; set; } = year;
    }
}