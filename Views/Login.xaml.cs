using Microsoft.Win32;

namespace slunaExamen.Views;

public partial class Login : ContentPage
{
    Dictionary<string, string> credentials = new()
    {
        { "estudiante2025", "moviles" },
        { "uisrael", "2025" },
        { "sistemas", "2025_1" }
    };

    public Login()
    {
        InitializeComponent();
    }

    private async void OnLoginClicked(object sender, EventArgs e)
    {
        string user = entryUser.Text?.Trim();
        string pass = entryPassword.Text?.Trim();

        if (credentials.TryGetValue(user, out string expectedPass) && expectedPass == pass)
        {
            await Navigation.PushAsync(new Registro(user));
        }
        else
        {
            await DisplayAlert("Error", "Usuario o contraseña incorrectos", "OK");
        }
    }

    private async void OnAcercaDeClicked(object sender, EventArgs e)
    {
        string user = entryUser.Text?.Trim();
        if (string.IsNullOrWhiteSpace(user)) user = "Desconocido";
        await Navigation.PushAsync(new AcercaDe(user));
    }

}