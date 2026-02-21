using Asp.NetHw8.Models;
using Asp.NetHw8.Services;

namespace Asp.NetHw8.InputModels
{
    public record class BookInputModel(string Title, string Author, string Genre, int Year, List<IFormFile>? Images);
}
