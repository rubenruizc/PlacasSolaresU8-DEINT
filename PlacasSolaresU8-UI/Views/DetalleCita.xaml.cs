namespace PlacasSolaresU8_UI.Views;
using PlacasSolaresU8_ENT;

public partial class DetalleCita : ContentPage
{
    public DetalleCita(clsCita cita)
    {
        InitializeComponent();

        BindingContext = cita;
    }

    /// <summary>
    /// Funci�n que 'guarda' la informaci�n
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void OnGuardarInformeClicked(object sender, EventArgs e)
    {

        await DisplayAlert("Guardado!", "Datos guardados correctamente", "OK");

    }
}
