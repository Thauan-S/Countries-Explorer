using CommunityToolkit.Maui.Views;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Domain.Models;

namespace CountriesExplorer.ViewModels
{
    public partial class CountryDetailViewModel : ObservableObject
    {
        private Country country;
        public CountryDetailViewModel(Country country)
        {
            this.country = country;
        }
        public Country Country => country;
        public Dictionary<string, Currency> Currencies => Country.Currencies;
    }
}
