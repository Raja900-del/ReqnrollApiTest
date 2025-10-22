using Microsoft.Extensions.DependencyInjection;
using Reqnroll.Microsoft.Extensions.DependencyInjection;
using ReqnrollApiTest.Core.Http;
using ReqnrollApiTest.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReqnrollApiTest
{
    public class SetupTestDependencies
    {

        [ScenarioDependencies]
        public static IServiceCollection CreateServices()
        {
            var services = new ServiceCollection();

            // Register core dependencies
            services.AddSingleton<IApiClient, RestSharpClient>();
            services.AddTransient<UserApi>();

            return services;
        }

    }
}
