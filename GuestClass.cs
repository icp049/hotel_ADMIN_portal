using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace Hotel_Management_System
{
 
    class GuestClass
    {
        DBConnect connect = new DBConnect();
       
        public DataTable getGuest()
        {
            string selectQuery = "SELECT c_id,c_lname,c_fname,c_email FROM `customers`";
            MySqlCommand command = new MySqlCommand(selectQuery, connect.GetConnection());
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            DataTable table = new DataTable();

            adapter.SelectCommand = command;
            adapter.Fill(table);

            return table;
        }
      
        public bool editGuest(string id, string fname, string lname, string phone)
        {
            string editQuerry = "UPDATE `customers` SET `c_id`=@id, `c_fname`=@fname,`c_lname`=@lname,`c_email`=@ph WHERE `c_id`=@id";
            MySqlCommand command = new MySqlCommand(editQuerry, connect.GetConnection());
         
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            command.Parameters.Add("@fname", MySqlDbType.VarChar).Value = fname;
            command.Parameters.Add("@lname", MySqlDbType.VarChar).Value = lname;
            command.Parameters.Add("@ph", MySqlDbType.VarChar).Value = phone;


            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }

        public bool removeGuest(string id)
        {
            string insertQuerry = "DELETE FROM `customers` WHERE `c_id`=@id";
            MySqlCommand command = new MySqlCommand(insertQuerry, connect.GetConnection());
           
            command.Parameters.Add("@id", MySqlDbType.VarChar).Value = id;
            connect.OpenCon();
            if (command.ExecuteNonQuery() == 1)
            {
                connect.CloseCon();
                return true;
            }
            else
            {
                connect.CloseCon();
                return false;
            }

        }
    }
}
