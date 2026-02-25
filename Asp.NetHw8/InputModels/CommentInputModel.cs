using System.ComponentModel.DataAnnotations;

namespace Asp.NetHw8.InputModels
{
    public record class CommentInputModel(string name, string text)
    {
        [Required]
        [MinLength(2)]
        public string Name { get; set; } = name;

        [Required]
        [MinLength(1)]
        public string Text { get; set; } = text;
    }
}
