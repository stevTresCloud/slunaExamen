namespace slunaExamen.Views;

public partial class Resumen : ContentPage
{
    public Resumen(string usuario, string nombre, string apellido, string va, string fecha,
                    string ciudad, string inicial, string cuota)
    {
        InitializeComponent();

        lblUsuario.Text = $"Usuario conectado: {usuario}";
        lblNombre.Text = nombre;
        lblApellido.Text = apellido;
        lblVA.Text = va;
        lblFecha.Text = fecha;
        lblCiudad.Text = ciudad;
        lblInicial.Text = inicial;
        lblCuota.Text = cuota;

        if (double.TryParse(cuota, out double cuotaVal) && double.TryParse(inicial, out double ini))
        {
            double total = cuotaVal * 3 + ini;
            lblTotal.Text = total.ToString("F2");
        }
    }

    private async void OnCerrarSesionClicked(object sender, EventArgs e)
    {
        await Navigation.PopToRootAsync();
    }
}