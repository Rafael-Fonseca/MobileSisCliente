using MobileSisCliente.ViewModels;
using MobileSisCliente.Views;
using System;
using System.Collections.Generic;
using Xamarin.Forms;

namespace MobileSisCliente
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(ItemDetailPage), typeof(ItemDetailPage));
            Routing.RegisterRoute(nameof(NewItemPage), typeof(NewItemPage));
        }

    }
}
