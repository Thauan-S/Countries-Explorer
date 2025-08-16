

using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using CountriesExplorer.Views;
using Domain.Models;
using Domain.Services;
using System.Collections.ObjectModel;

namespace CountriesExplorer.ViewModels
{
    public partial class CountryViewModel : ObservableObject
    {
        private readonly ICountriesService _countriesService;

        public CountryViewModel(ICountriesService countriesService)
         {
            _countriesService = countriesService;
        }

        public ObservableCollection<Country> Countries { get; set; } = [];


        [RelayCommand]
        private  async Task SelectCountry(Country country)
        {
            var popup = new CountryDetail(country);
            await Application.Current.MainPage.ShowPopupAsync(popup);
        }
        
        [RelayCommand]
        private async Task GetCountries()
        {
            var list = await _countriesService.GetAllCountriesAsync();
            foreach (var country in list)
            { 
                Countries.Add(country);
            }
            
            //Countries = new ObservableCollection<Country>(list);
        }
    }
}
