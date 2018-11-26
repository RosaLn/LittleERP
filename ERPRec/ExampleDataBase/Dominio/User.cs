using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExampleDataBase.Dominio.Gestores;

namespace ExampleDataBase.Dominio
{
    class User
    {
        public User(int iD, string name, string pass, int deleted)
        {
            ID = iD;
            Name = name;
            Pass = pass;
            Deleted = deleted;
            Gestor = new GestorUsuarios();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string Pass { get; set; }
        public int Deleted { get; set; }
        public GestorUsuarios Gestor { get; set; }

    }
}
