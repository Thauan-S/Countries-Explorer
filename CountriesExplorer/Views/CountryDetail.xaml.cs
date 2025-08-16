using CommunityToolkit.Maui.Views;
using CountriesExplorer.ViewModels;
using Domain.Models;

namespace CountriesExplorer.Views;

public partial class CountryDetail : Popup
{
    public CountryDetail(Country country)
    {
        InitializeComponent();
        BindingContext = new CountryDetailViewModel(country);
    }
    private void OnCloseClicked(object sender, EventArgs e)
    {
        Close();
    }
}