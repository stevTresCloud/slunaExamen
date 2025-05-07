namespace slunaExamen.Views;

public partial class AcercaDe : ContentPage
{
    public AcercaDe(string usuario)
    {
        InitializeComponent();
        lblUsuario.Text = $"Usuario conectado: {usuario}";
    }
}