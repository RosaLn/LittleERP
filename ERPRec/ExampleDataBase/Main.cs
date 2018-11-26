using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExampleDataBase
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            DataSet data = new DataSet();
            ConnectOracle Search=new ConnectOracle();            

            data = Search.getData("Select * from clientes order by idcliente", "customers");

            DataTable tcustomers = data.Tables["customers"];

            //dgvCustomers.DataSource = tcustomers;

            dgvCustomers.Columns.Add("ID", "ID");
            dgvCustomers.Columns.Add("NAME", "NAME");
            dgvCustomers.Columns.Add("SURNAME", "SURNAME");
            dgvCustomers.Columns.Add("PHONEDATE", "PHONEDATA");
            DateTime Hoy = DateTime.Today;

            foreach (DataRow row in tcustomers.Rows)
            {
                dgvCustomers.Rows.Add(row["IDCLIENTE"], row["NOMBRE"], row["APELLIDO1"] + " " + row["APELLIDO2"], Hoy.ToString("dd-MM-yyyy"));
            }


        }
    }
}
