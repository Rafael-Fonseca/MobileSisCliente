using System;
using MobileSisCliente.Helpers.MVVM;
using MobileSisCliente.Models;
using Newtonsoft.Json;
using Xamarin.Forms;
using System.Windows.Input;
using MobileSisCliente.Services;

namespace MobileSisCliente.ViewModels
{
    [QueryProperty("ClientSerialized", "client")]
    public class ClientUpdatePageViewModel : BaseViewModel
    {
        public Client Client { get; set; }
        public ICommand SaveButton { get; set; }
        public ICommand DeleteButton { get; set; }

        public String ClientSerialized { 
            set {
                Client = JsonConvert.DeserializeObject<Client>(Uri.UnescapeDataString(value));
                OnPropertyChanged(nameof(Client));
            } 
        }

        public ClientUpdatePageViewModel()
        {
            //SaveButton = new Command<ClientDTO>(OnSaveButtonPressed);
            //DeleteButton = new Command<Int32>(OnDeleteButtonPressed);

        }
        /*
        private async void OnSaveButtonPressed(ClientDTO client)
        {
            string SerializedClient = JsonConvert.SerializeObject(client);
            //TODO: Enviar requisição PATH
            await new HttpService().SaveClientAsync(client);
            //TODO: ALERT Resultado
            await Shell.Current.GoToAsync("clients");

        }

        private void OnDeleteButtonPressed(int clientId)
        {
            var requester = new HttpService();
            //TODO: Enviar requisição Delete
            await requester.DeleteAsync(clientId);
            //TODO: ALERT Resultado
            Shell.Current.GoToAsync("clients");
        }
        */
    }
}
