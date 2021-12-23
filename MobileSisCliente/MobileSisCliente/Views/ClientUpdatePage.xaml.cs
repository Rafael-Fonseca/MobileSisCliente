using MobileSisCliente.Models;
using MobileSisCliente.Services;
using MobileSisCliente.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MobileSisCliente.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ClientUpdatePage : ContentPage
    {
        public ClientUpdatePage()
        {
            InitializeComponent();
        }

        async void OnUpdateButtonClicked(object sender, EventArgs e)
        {
            var requester = new HttpService();
            var context = (ClientUpdatePageViewModel)BindingContext;

            await new HttpService().SaveClientAsync(context.Client);
            //TODO: ALERT Resultado
            await Shell.Current.GoToAsync("clients");


        }

        async void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            var requester = new HttpService();
            var context = (ClientUpdatePageViewModel)BindingContext;
            //Debug.WriteLine("---->\n\n-----> ID:\n" + context.Client.Id+ "\n====== END ======\n");
            await requester.DeleteAsync(context.Client.Id);
            
            //TODO: ALERT Resultado
            await Shell.Current.GoToAsync("clients");
        }

    }
}