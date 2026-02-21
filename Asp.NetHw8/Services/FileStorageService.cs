using System.Security.Cryptography.X509Certificates;

namespace Asp.NetHw8.Services
{
    public static class FileStorageService
    {
        async public static Task<IEnumerable<string>> SaveImagesAsync(IEnumerable<IFormFile> images, string folderPath = "wwwroot/images")
        {
            List<string> savedFilePath = new List<string>();

            if (images is null)
                return savedFilePath;

            if(!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }

            foreach (IFormFile image in images)
            {
                if(image.Length > 0)
                {
                    string extension = Path.GetExtension(image.FileName);
                    string uniqueImageName = $"{Guid.NewGuid()}{extension}";

                    string fullPath = Path.Combine(folderPath, uniqueImageName);
                    using (FileStream stream = new FileStream(fullPath, FileMode.Create))
                    {
                        await image.CopyToAsync(stream);
                    }

                    string relativePath = $"/images/{uniqueImageName}";
                    savedFilePath.Add(relativePath);
                }
            }

            return savedFilePath;
        }
    }
}
