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


        public int insertCustomer(Clientes c)
        {
            int correct = -1;
            ConnectOracle Search = new ConnectOracle();
            if (!dniExist(c.Dni))
            {
                Search.setData("insert into customers values(0,'" + c.Dni + "','" + c.Name + "','" + c.Surname + "','"
                    + c.Address + "'," + c.Phone + ",'" + c.Email + "',0," + c.ZipCode + ")");
                correct = 0;
            }

            return correct;
        }


        public int updateCustomer(Clientes c)
        {
            int correct = -1;
            ConnectOracle Search = new ConnectOracle();


            return correct;
        }

        public bool dniExist(string dni)
        {
            bool exists = true;
            DataSet data = new DataSet();
            ConnectOracle Search = new ConnectOracle();

            int count = Convert.ToInt16(Search.DLookUp("count(*)", "customers", "DNI_CIF=" + dni));
            if (count == 0)
            {
                exists = false;
            }

            return exists;
        }


    }

   
}
