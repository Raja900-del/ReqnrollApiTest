using FluentAssertions;
using ReqnrollApiTest.Services;
using RestSharp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ReqnrollApiTest.StepDefinitions
{
    [Binding]
    public class CreateUserSteps
    {
        private readonly UserApi _usersApi;
        private RestResponse? _response;

        public CreateUserSteps(UserApi usersApi)
        {
            _usersApi = usersApi;
        }

        [When("I create a user with name {string} and job {string}")]
        public async Task WhenICreateAUserWithNameAndJob(string name, string job)
        {
            _response = await _usersApi.CreateUserAsync(name, job);
        }

        [Then("the response status should be {int}")]
        public void ThenTheResponseStatusShouldBe(int statusCode)
        {
            ((int)_response!.StatusCode).Should().Be(statusCode);
        }

    }
}
