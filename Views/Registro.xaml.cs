namespace slunaExamen.Views;

public partial class Registro : ContentPage
{
    private string usuario;
    private const double costoUPS = 300;

    public Registro(string usuario)
    {
        InitializeComponent();
        this.usuario = usuario;
        lblUsuario.Text = $"Usuario conectado: {usuario}";
        pickerVA.ItemsSource = new List<string>
        {
            "500",
            "750",
            "1000",
        };
        pickerCiudad.ItemsSource = new List<string>
        {
            "Quito",
            "Guayaquil",
            "Cuenca",
            "Loja",
            "Machala",
            "Ambato",
            "Manta",
            "Esmeraldas",
            "Ibarra",
            "Durán"
        };
    }

    private void OnCalcularPagoClicked(object sender, EventArgs e)
    {
        double inicial = costoUPS * 0.15;
        entryInicial.Text = inicial.ToString("F2");

        double saldo = costoUPS - inicial;
        double interes = costoUPS * 0.05;
        double cuota = (saldo / 3) + interes;
        entryCuota.Text = cuota.ToString("F2");
    }

    private async void OnVerResumenClicked(object sender, EventArgs e)
    {
        await Navigation.PushAsync(new Resumen(
            usuario,
            entryNombre.Text,
            entryApellido.Text,
            pickerVA.SelectedItem?.ToString() ?? "",
            datePickerFecha.Date.ToShortDateString(),
            pickerCiudad.SelectedItem?.ToString() ?? "",
            entryInicial.Text,
            entryCuota.Text
        ));
    }
}