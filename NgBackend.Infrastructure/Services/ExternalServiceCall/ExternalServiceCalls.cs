using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

// using BuberDinner.application.Interfaces.ExternalService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using NgBackend.Application.Interfaces.ExternalServiceCall;

namespace NgBackend.Infrastructure.Services.ExternalServiceCall
{
    public class ExternalServiceCalls : IExternalSerivce
    {
        private readonly HttpClient _httpClientFactory;
        private readonly IHttpClientFactory _httpClientFactoryNew;
        private readonly ConfigurationBuilder _configurationBuilder;



        public ExternalServiceCalls(HttpClient httpClientFactory, ConfigurationBuilder configurationBuilder, IHttpClientFactory httpClientFactoryNew)
        {
            _httpClientFactory = httpClientFactory;
            _configurationBuilder = configurationBuilder;
            _httpClientFactoryNew = httpClientFactoryNew;
        }

        // public ExternalServiceCalls(ConfigurationBuilder configurationBuilder)
        // {
        //     _configurationBuilder = configurationBuilder;
        // }

        public async Task<String> StartProcess(string key, Dictionary<string, object> Dictemplate)
        {
            var client = _httpClientFactoryNew.CreateClient("camundaClient");
            Console.WriteLine("Base Addr==>>"+client.BaseAddress);
            var url = _configurationBuilder.AddJsonFile("appsettings.json").Build().GetSection("CamundaApi")["url"];
            Console.WriteLine(url);
            var cust = JsonSerializer.Serialize(Dictemplate);
            var requestContent = new StringContent(cust, Encoding.UTF8, "application/json");
            // var client = _httpClientFactory.CreateClient();
            var response = await client.PostAsync(client.BaseAddress + "process-definition/key/" + key + "/start", requestContent);
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }

        public async Task<String> otherMicroServiceCall()
        {

            // var url = _configurationBuilder.AddJsonFile("appsettings.json").Build().GetSection("CamundaApi")["url"];
            // Console.WriteLine(url);
            // var cust = JsonSerializer.Serialize(Dictemplate);
            // var requestContent = new StringContent(cust, Encoding.UTF8, "application/json");
            // var client = _httpClientFactory.CreateClient();
            var client = _httpClientFactoryNew.CreateClient("testApi");
            Console.WriteLine("Base Addr==>>"+client.BaseAddress);
            var response = await _httpClientFactory.GetAsync(client.BaseAddress+"WeatherForecast/test");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return content;
        }
    }
}