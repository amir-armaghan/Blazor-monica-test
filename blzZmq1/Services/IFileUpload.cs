using BlazorInputFile;
using System.Threading.Tasks;
namespace blzZmq1.Services
{
    public interface IFileUpload
    {
        Task UploadAsync(IFileListEntry file);
    }
}