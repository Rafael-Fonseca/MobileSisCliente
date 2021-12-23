using MobileSisCliente.Helpers.MVVM;
using System.Windows.Input;
using MobileSisCliente.Models;
using Xamarin.Forms;
using MobileSisCliente.Services;
using System.Diagnostics;
using System;

namespace MobileSisCliente.ViewModels
{

    public class ClientEntryViewModel : BaseViewModel
    {
        public ICommand SaveButton { get; set; }
        public Client Client { get; set;}


        public ClientEntryViewModel()
        {
            Client = new Client();
            SaveButton = new Command<Client>(OnSaveButtonPressed);

        }

        private async void OnSaveButtonPressed(Client client)
        {
            //Debug.WriteLine("-------------------->\n------------------------->\n\n" + "ENTREI EM OnSaveButtonPressed do Cliente Entry" + "\n\n--------------------^^\n----------------------^^\n");
            await new HttpService().SaveClientAsync(Client, true);
            await Shell.Current.GoToAsync("clients");

        }

    }
}
