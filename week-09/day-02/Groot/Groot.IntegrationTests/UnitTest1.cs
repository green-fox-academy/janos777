using Groot.Controllers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.TestHost;
using Newtonsoft.Json;
using System;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Xunit;

namespace Groot.IntegrationTests
{
    public class GuardianTests
    {
        private HttpClient Client;
        private TestServer Server;

        public GuardianTests()
        {
            //arrange
            Server = new TestServer(new WebHostBuilder().UseStartup<Startup>());
            Client = Server.CreateClient();
        }

        [Fact]
        public async Task IndexShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task GrootShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("/");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ParameterShouldReturnOkStatus()
        {
            //act
            var response = await Client.GetAsync("groot?message=somemessage");

            //assert
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        [Fact]
        public async Task ResponseShouldReturnAsExpected()
        {
            //act
            var response = await Client.GetAsync("groot?message=somemessage");

            //assert
            var responseText = new ResponseTextDTO { received = "somemessage", translated = "I am Groot!" };

            Assert.Equal(JsonConvert.SerializeObject(responseText), response.Content.ReadAsStringAsync().Result);
        }

        [Fact]
        public async Task WithoutParameterShouldReturnNotOkStatus()
        {
            //act
            var response = await Client.GetAsync("groot");

            //assert
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }

        [Fact]
        public async Task ErrorResponseShouldReturnAsExpected()
        {
            //act
            var response = await Client.GetAsync("groot?");

            //assert
            var responseError = new ResponseErrorDTO { error = "I am Groot!" };

            Assert.Equal(JsonConvert.SerializeObject(responseError), response.Content.ReadAsStringAsync().Result);
        }

        public class ResponseTextDTO
        {
            public string received;
            public string translated;
        }

        public class ResponseErrorDTO
        {
            public string error;
        }
    }
}
