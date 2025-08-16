using Domain.Models;
using Domain.Services;
using System.Net.Http.Json;

namespace Infrastructure.Services
{
    public class CountriesService : ICountriesService
    {
        private readonly HttpClient _httpClient;

        public CountriesService(HttpClient httpClient)
        {
            _httpClient = httpClient;                        
        }

        public async Task<List<Country>> GetAllCountriesAsync()
        {
            try
            {
                var countries = await _httpClient.GetFromJsonAsync<List<Country>>("all?fields=name,capital,region,flags,currencies") ?? new List<Country>();
                return countries;
            }
            catch (Exception ex)
            {
                return new List<Country>();
            }
        }
    }
}
