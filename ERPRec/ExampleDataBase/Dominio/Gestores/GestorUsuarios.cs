using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;

namespace ExampleDataBase.Dominio.Gestores
{
    class GestorUsuarios
    {
        private DataTable tabla { get; set; }

        public GestorUsuarios()
        {
            tabla = new DataTable();
        }

        public void leerusuarios()
        {
            DataSet data = new DataSet();
            ConnectOracle Search = new ConnectOracle();

            data = Search.getData("Select * from users order by idcustomer", "users");

            tabla = data.Tables["users"];
        }

        public static bool CheckLog(User u)
        {
            bool valid = false;



            return valid;
        }
    }

   
}
