using BlazorInputFile;
using System.Threading.Tasks;
namespace blzZmq1.Services
{
    public interface IFileUpload
    {
        void DeleteExistingFiles();

        Task<string> UploadAsync(IFileListEntry file);

        Task<string> GetFileContentAsync(string uriString);
    }
}