using System;
using System.Collections.ObjectModel;
using MobileSisCliente.Models;
using MobileSisCliente.Services;
using MobileSisCliente.Helpers.MVVM;
using System.Windows.Input;
using Xamarin.Forms;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace MobileSisCliente.ViewModels
{
    public class ClientsPageViewModel : BaseViewModel
    {
        public Task<ObservableCollection<Client>> x = new HttpService().GetClients();
        public ICommand UpdateButton { get; set; }

        private ObservableCollection<Client> _clients;
        public ObservableCollection<Client> Clients
        {
            get {
                return _clients;
            }
            set {
                SetProperty(ref _clients, value);
            }
        }

        public ClientsPageViewModel()
        {
            OnAppearing();
            UpdateButton = new Command<Client>(OnUpdateButtonPressed);
        }

        private void OnUpdateButtonPressed(Client client)
        {
            string SerializedClient = JsonConvert.SerializeObject(client);
            Shell.Current.GoToAsync($"update?client={Uri.EscapeDataString(SerializedClient)}");
        }

        protected async void OnAppearing()
        {
            Clients = await new HttpService().GetClients();
        }
    }
}