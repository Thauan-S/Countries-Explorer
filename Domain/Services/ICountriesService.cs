using Domain.Models;

namespace Domain.Services
{
    public interface ICountriesService
    {
        Task<List<Country>> GetAllCountriesAsync();
    }
}
