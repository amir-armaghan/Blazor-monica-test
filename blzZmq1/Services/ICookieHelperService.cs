using System.Threading.Tasks;

namespace blzZmq1.Services
{
    public interface ICookieHelperService
    {
        Task<object> GetAsync(string name);
        Task WriteAsync(string name, string value, int? days = null);
    }
}