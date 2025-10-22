using ReqnrollApiTest.Core.Http;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollApiTest.Services
{

  
    public class UserApi
    {

        private readonly IApiClient _client;

        public UserApi(IApiClient apiClient)
        {
                _client = apiClient;
        }

        public Task<RestResponse> CreateUserAsync(string name, string job)
        {
           var payloadRequest =  _client.SendAsync("/api/users", Method.Post, new { name, job });
           return payloadRequest;
        }
    }
}
