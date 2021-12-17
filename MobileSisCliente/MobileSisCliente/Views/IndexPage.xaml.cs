using System;
using System.IO;
using Xamarin.Forms;

namespace MobileSisCliente.Views
{
    public partial class IndexPage : ContentPage
    {
        string _fileName = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "clients.txt");
        public IndexPage()
        {
            InitializeComponent();

            if (File.Exists(_fileName))
            {
                name.Text = File.ReadAllText(_fileName);
            }
        }

        void OnSaveButtonClicked(object sender, EventArgs e)
        {
            // Save the file.
            File.WriteAllText(_fileName, name.Text);
        }

        void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            // Delete the file.
            if (File.Exists(_fileName))
            {
                File.Delete(_fileName);
            }
            name.Text = string.Empty;
        }
    }
}