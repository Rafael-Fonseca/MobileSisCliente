using System;
using System.Collections.Generic;
using System.Text;

namespace MobileSisCliente.Models
{
    public class ResponseGetClients
    {
        public int total_items { get; set; }
        public int total_pages { get; set; }
        public int current_page { get; set; }
        public int items_page { get; set; }
        public IList<Client> data { get; set; }
    }
}
