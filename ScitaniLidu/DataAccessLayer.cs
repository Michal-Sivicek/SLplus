using Microsoft.VisualBasic.ApplicationServices;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;



namespace ScitaniLidu
{
    public class DataAccessLayer
    {
        private MySql.Data.MySqlClient.MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        public bool InsertUser(User user)
        {
            dynamic config = Config.GetConfig();
            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
            try
            {
                connection.Open();
                
                //vytvoření SQL dotazu pro vložení uživatele do tabulky users_info
                string query = "INSERT INTO users_info (jmeno, prijmeni, bydliste, nabozenstvi, telefonni_cislo, email, narodnost, statni_obcanstvi, vzdelani) VALUES (@jmeno, @prijmeni, @bydliste, @nabozenstvi, @telefonni_cislo, @email, @narodnost, @statni_obcanstvi, @vzdelani)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@jmeno", user.jmeno);
                command.Parameters.AddWithValue("@prijmeni", user.prijmeni);
                command.Parameters.AddWithValue("@bydliste", user.bydliste);
                command.Parameters.AddWithValue("@nabozenstvi", user.nabozenstvi);
                command.Parameters.AddWithValue("@telefonni_cislo", user.telefonni_cislo);
                command.Parameters.AddWithValue("@email", user.email);
                command.Parameters.AddWithValue("@narodnost", user.narodnost);
                command.Parameters.AddWithValue("@statni_obcanstvi", user.statni_obcanstvi);
                command.Parameters.AddWithValue("@vzdelani", user.vzdelani);
                command.ExecuteNonQuery();
                //uzavření připojení k databázi
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}
