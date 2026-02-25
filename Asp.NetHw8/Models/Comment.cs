namespace Asp.NetHw8.Models
{
    public class Comment (string name, string text)
    {
        public string Name { get; set; } = name;
        public string Text { get; set; } = text;
    }
}
