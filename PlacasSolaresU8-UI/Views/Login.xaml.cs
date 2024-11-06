namespace PlacasSolaresU8_UI.Views;

public partial class Login : ContentPage
{
	public Login()
	{
		InitializeComponent();
	}

    /// <summary>
    /// Función que al pulsar el botón de login comprueba que las credenciales sean correctas,
    /// en caso afirmativo pasa a la siguiente pantalla y en caso negativo, muestra un mensaje de error.
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void LoginButton_Click(object sender, EventArgs e)
    {
        string username = txtUsername.Text;
        string password = txtPassword.Text;

        if (username == "ruben" && password == "1234")
        {
            await DisplayAlert("Éxito", "Inicio de sesión exitoso", "OK");
            
            await Navigation.PushAsync(new Home());
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }
}
