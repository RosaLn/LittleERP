using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDataBase.Dominio
{
    class Clientes
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Dni { get; set; }
        public string Surname { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        public string Email { get; set; }
        public int ZipCode { get; set; }
        public int Delete { get; set; }

        public Gestores.GestorClientes g { get; }

        public Clientes(int id, string name, string dni, string surname, string address, int phone, string email, int zipCode, int delete)
        {
            Id = id;
            Name = name;
            Dni = dni;
            Surname = surname;
            Address = address;
            Phone = phone;
            Email = email;
            ZipCode = zipCode;
            Delete = delete;
            g = new Gestores.GestorClientes(ca);
        }
    }
}
