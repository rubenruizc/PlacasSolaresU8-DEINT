namespace PlacasSolaresU8_UI.Views;
using PlacasSolaresU8_ENT;
using PlacasSolaresU8_DAL;

public partial class Home : ContentPage
{
    public Home()
    {
        InitializeComponent();

        List<clsCita> lista = clsListadoCitas.obtenerCitas();

        listaView.ItemsSource = lista;

        List<clsCita> listaNoCompletadas = clsListadoCitas.obtenerCitasNoCompletadas();

        listaViewNoCompletadas.ItemsSource = listaNoCompletadas;
    }

    /// <summary>
    /// Función que al pulsar en una cita, la obtiene y va a la pantalla detalles
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnCitaSelected(object sender, SelectedItemChangedEventArgs e)
    {
        var citaSeleccionada = e.SelectedItem as clsCita;

        if (citaSeleccionada != null)
        {
            await Navigation.PushAsync(new DetalleCita(citaSeleccionada));
        }
    }
}