using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ExampleDataBase.Dominio.Gestores
{
    class GestorClientes
    {
        private DataTable tabla;

        public GestorClientes()
        {
            tabla = new DataTable();
        }
        public DataTable getClientes()
        {
            return tabla;
        }

        public void leerclientes()
        {
            DataSet data = new DataSet();
            ConnectOracle Search = new ConnectOracle();

            data = Search.getData("Select * from customers order by idcustomer", "customers");

            tabla = data.Tables["customers"];
        }
    }

   
}
