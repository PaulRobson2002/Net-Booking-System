using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Net_Booking_System
{
    public static class dbinfo
    {
        public static readonly string userCon = "server=localhost;database=bookingsys;uid=root;"; // Connection string
        public static readonly string AddUserQuery = "insert into bookingsys.users(Fname,Password,DOB,Surname) values(@fname,@pwd,@dob,@sname);"; // Add user to db queery
        public static void Addtouser(string fname, string pass, string date, string Sname) // add a methord to the class
        {

            MySqlConnection cnn = new MySqlConnection(dbinfo.userCon); // Set Connection
            MySqlCommand UserCommand = new MySqlCommand(dbinfo.AddUserQuery, cnn); // Add Command
            UserCommand.Parameters.AddWithValue("@fname", fname); // firstname param
            UserCommand.Parameters.AddWithValue("@pwd", pass); // password param
            UserCommand.Parameters.AddWithValue("@dob", date); // date of birth param
            UserCommand.Parameters.AddWithValue("@sname", Sname); // sirname param

            MySqlDataReader UserReader; // The Reader
            try // try the querry
            {
                cnn.Open(); // open connection
                UserReader = UserCommand.ExecuteReader(); // start queery
                cnn.Close(); // close connection
                Console.WriteLine("Success"); // debugging
            }
            catch (Exception ex) // catch any errors
            {
                Console.WriteLine("Error" + ex.Message); // debugging
            }
        }
    }
    /*
            MySqlConnection cnn = new MySqlConnection(dbinfo.userCon); // Set Connection
            MySqlCommand UserCommand = new MySqlCommand(dbinfo.AddUserQuery, cnn); // Add Command
            MySqlDataReader UserReader; // The Reader
            try
            {
                cnn.Open(); // open connection
                UserReader = UserCommand.ExecuteReader();
                MessageBox.Show("Save Data");
                cnn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     */

    
}
