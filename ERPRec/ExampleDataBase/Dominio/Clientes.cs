using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleDataBase.Dominio
{
    class Clientes
    {
        private String Nombre;
        private Gestores.GestorClientes g;
        public Clientes ()
        {
            g = new Gestores.GestorClientes();
        }
        public Gestores.GestorClientes gestor()
        {
            return g;
        }
        public String getNombre()
        {
            return Nombre;
        }
        public void setNombre(String Nombre)
        {
            this.Nombre = Nombre;
        }
    }
}
