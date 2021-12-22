using System;
using System.Collections.Generic;
using System.Text;
using MobileSisCliente.Models;
using MobileSisCliente.Services;
using MobileSisCliente.Helpers.MVVM;
//using System.Windows.Input;
//using Xamarin.Forms;

namespace MobileSisCliente.ViewModels
{
    public class ClientsPageViewModel : BaseViewModel
    {
        private List<Client> _clients;
        public List<Client> Clients
        {
            get
            {
                return _clients;
            }
            set
            {
                SetProperty(ref _clients, value);
            }
        }

        public ClientsPageViewModel()
        {
            Clients = new ClientService().GetClients();
        }
    }
}