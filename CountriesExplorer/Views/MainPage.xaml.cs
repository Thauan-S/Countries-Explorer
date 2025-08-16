using CountriesExplorer.ViewModels;
using Microsoft.Maui.Controls;

namespace CountriesExplorer
{
    public partial class MainPage : ContentPage
    {
        public MainPage(CountryViewModel viewModel )
        {
            InitializeComponent();
            BindingContext = viewModel;
        }
    }
}
