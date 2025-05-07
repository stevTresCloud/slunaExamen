using slunaExamen.Views;

namespace slunaExamen
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            // Fix: Wrap the NavigationPage in a Window instance
            return new Window(new NavigationPage(new Login()));
        }
    }
}