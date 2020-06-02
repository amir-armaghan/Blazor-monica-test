using Microsoft.Extensions.DependencyInjection;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace blzZmq1.Services
{
    public class CookieHelperService : ICookieHelperService
    {
        private IJSRuntime _jsRuntime;
        private readonly IServiceProvider _serviceProvider;

        public CookieHelperService(
            //IJSRuntime jsRuntime
            IServiceProvider serviceProvider
            )
        {
            _serviceProvider = serviceProvider;
            //_jsRuntime = jsRuntime;
        }

        public async Task WriteAsync(string name, string value, int? days = null)
        {
            _jsRuntime = _serviceProvider.GetRequiredService<IJSRuntime>();
            var result = await _jsRuntime.InvokeAsync<string>("UserCookies.WriteCookie", name, value, days);
        }

        public async Task<object> GetAsync(string name)
        {
            //try
            //{
            _jsRuntime = _serviceProvider.GetRequiredService<IJSRuntime>();
                var result = await _jsRuntime.InvokeAsync<object>("UserCookies.GetCookie", name);
            return result;
            //}
            //catch(Exception ex)
            //{
            //    return null;
            //}
        }
    }
}
