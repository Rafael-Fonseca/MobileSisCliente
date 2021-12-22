using System;
using System.Collections.Generic;
using System.Text;

namespace MobileSisCliente.Models
{
    public class Client
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Gender { get; set; }
    }
}
