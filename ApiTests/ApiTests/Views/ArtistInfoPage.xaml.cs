using ApiTests.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ApiTests.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ArtistInfoPage : ContentPage
    {
        public ArtistInfoPage()
        {
            InitializeComponent();
            BindingContext = new ArtistInfoPageViewModel();
        }

    }
}