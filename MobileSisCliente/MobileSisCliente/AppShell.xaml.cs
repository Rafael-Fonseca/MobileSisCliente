using Xamarin.Forms;

namespace MobileSisCliente
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute("update", typeof(Views.ClientUpdatePage));
            Routing.RegisterRoute("clients", typeof(Views.ClientsPage));
        }

    }
}
