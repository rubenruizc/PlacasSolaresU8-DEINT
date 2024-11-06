using PlacasSolaresU8_UI.Views;

namespace PlacasSolaresU8_UI
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new Login());
        }
    }
}
