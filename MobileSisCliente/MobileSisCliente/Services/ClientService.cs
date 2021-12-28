using System;
using System.Collections.Generic;
using MobileSisCliente.Models;

namespace MobileSisCliente.Services
{
    public class ClientService
    {
        public List<Client> GetClients()
        {
            var clients = new List<Client>()
            {
                new Client()
                {
                    Id = 1,
                    Name ="Rafael Fonseca",
                    BirthDate = DateTime.Now,
                    Gender = "Masculino"
                },
                new Client()
                {
                    Id = 2,
                    Name = "Fernanda Fonseca",
                    BirthDate = DateTime.Now,
                    Gender = "Feminino"
                },
                new Client()
                {
                    Id = 3,
                    Name = "Matheus Fonseca",
                    BirthDate = DateTime.Now,
                    Gender = "Masculino"
                },
                new Client()
                {
                    Id = 4,
                    Name = "Isabela Eifert",
                    BirthDate = DateTime.Now,
                    Gender = "Feminino"
                }
            };

            return clients;
        }
    }
}
