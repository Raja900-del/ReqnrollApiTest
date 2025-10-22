using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollApiTest.Core.Http
{
    internal class RestSharpClient : IApiClient
    {
        private readonly RestClient _client = new("https://reqres.in"); // public demo API
        public async Task<RestResponse> SendAsync(string resource, Method method, object? body = null)
        {
            var request = new RestRequest(resource, method);
            request.AddHeader("x-api-key", "reqres-free-v1");
            if(body != null) request.AddJsonBody(body);
            return await _client.ExecuteAsync(request);
        
        }
    }
}
