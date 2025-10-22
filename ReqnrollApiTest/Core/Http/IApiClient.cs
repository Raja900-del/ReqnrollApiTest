using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollApiTest.Core.Http
{
    public interface IApiClient
    {
        Task<RestResponse> SendAsync(string resource, Method method, object? body = null);
    }
}
