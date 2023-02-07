using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
namespace Hotel_Management_System
{
    class InvoiceClass
    {
        DBConnect connect = new DBConnect();
       
        public DataTable getInvoice()
        {
            string selectQuery = "SELECT * FROM `invoice`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }

   

    
    }



}
