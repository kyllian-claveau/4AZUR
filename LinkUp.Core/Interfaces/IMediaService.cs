using Microsoft.AspNetCore.Http;

namespace LinkUp.Core.Interfaces;

public interface IMediaService
{
    Task<string> UploadMediaAsync(IFormFile file);
    Task DeleteMediaAsync(string mediaUrl);
}