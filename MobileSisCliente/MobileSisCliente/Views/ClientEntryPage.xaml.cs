using MobileSisCliente.Services;
using MobileSisCliente.ViewModels;
using System;
using Xamarin.Forms;

namespace MobileSisCliente.Views
{
    public partial class ClientEntryPage : ContentPage
    {
        public ClientEntryPage()
        {
            InitializeComponent();
        }

        async void OnAddButtonClicked(object sender, EventArgs e)
        {
            var requester = new HttpService();
            var context = (ClientEntryViewModel)BindingContext;

            await new HttpService().SaveClientAsync(context.Client, true);
            //TODO: ALERT Resultado
            await Shell.Current.GoToAsync("clients");


        }

    }
}