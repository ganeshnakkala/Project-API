using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace MVC.Models
{
    public class ApiRequest
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiBaseUrl;

        public ApiRequest(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _apiBaseUrl = configuration.GetValue<string>("ServiceUrls:VillaAPI");  // Fetch the API URL from appsettings
        }

        // Method to call the "Hello" API endpoint
        public async Task<string> GetHelloAsync()
        {
            var response = await _httpClient.GetAsync($"{_apiBaseUrl}/api/Home");
            return await response.Content.ReadAsStringAsync();
        }

        // Method to call the "Hello + Name" API endpoint
        public async Task<string> GetPersonalizedHelloAsync(string name)
        {
            var response = await _httpClient.GetAsync($"{_apiBaseUrl}/api/Home/hello?name={name}");
            return await response.Content.ReadAsStringAsync();
        }
    }
}
