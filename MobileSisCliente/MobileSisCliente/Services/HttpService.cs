using MobileSisCliente.Models;
using Newtonsoft.Json;
using System;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MobileSisCliente.Services
{

    public class HttpService
    {
        private string Url;
        HttpClient _requester;

        public HttpService()
        {
            _requester = new HttpClient();
            Url = "https://3850-189-6-21-143.ngrok.io/api/Cliente";
        }


        public async Task<ObservableCollection<Client>> GetClients()
        {
            string uri = Url + "/1/40";
            try
            {
                string answer = await _requester.GetStringAsync(uri);
                ResponseGetClients response = JsonConvert.DeserializeObject<ResponseGetClients>(answer);
                return new ObservableCollection<Client>(response.data);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("-------------------->\n------------------------->\n" + ex + "--------------------^^\n----------------------^^\n");
                return new ObservableCollection<Client>();
            }
            

        }


        public async Task SaveClientAsync(Client client, bool isNewItem = false)
        {
            try
            {
                if (isNewItem)
                {
                    string uri = Url;
                    ClientDTO newClient = new ClientDTO
                                                    {
                                                        Name= client.Name,
                                                        BirthDate= client.BirthDate,
                                                        Gender= client.Gender,
                                                    };
                
                    string json = JsonConvert.SerializeObject(newClient);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await _requester.PostAsync(uri, content);

                }
                else
                {
                    string uri = Url + $"/{client.Id}";
                    string json = JsonConvert.SerializeObject(client);
                    StringContent content = new StringContent(json, Encoding.UTF8, "application/json");
                    HttpResponseMessage response = await _requester.PutAsync(uri, content);

                }

            }
            catch (Exception ex)
            {
                Debug.WriteLine("-------------------->\n------------------------->\n" + @"\tERROR {0}", ex.Message + "--------------------^^\n----------------------^^\n");
            }
        }

        public async Task DeleteAsync(int id)
        {
            string uri = Url+$"/{id}";
            HttpResponseMessage response = await _requester.DeleteAsync(uri);
            if (response.IsSuccessStatusCode)
            {
                Debug.WriteLine(@"\tTodoItem successfully deleted.");
            }
        }
    }

    
}
