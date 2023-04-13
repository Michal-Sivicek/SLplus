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

        public bool InsertUser(UserPopulation user)
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

        public bool InsertHouse(UserHouse house)
        {
            dynamic config = Config.GetConfig();
            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                // vytvoření SQL dotazu pro vložení informací o domě do tabulky users_info_houses
                string query = "INSERT INTO users_info_houses (jmeno_prijmeni, obec, cislo_domu, ulice, psc, obydlenost_domu, rok_vystavby, material_zdi, pocet_podlazi) VALUES (@jmeno_prijmeni, @obec, @cislo_domu, @ulice, @psc, @obydlenost_domu, @rok_vystavby, @material_zdi, @pocet_podlazi)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@jmeno_prijmeni", house.jmeno_prijmeni);
                command.Parameters.AddWithValue("@obec", house.obec);
                command.Parameters.AddWithValue("@cislo_domu", house.cislo_domu);
                command.Parameters.AddWithValue("@ulice", house.ulice);
                command.Parameters.AddWithValue("@psc", house.psc);
                command.Parameters.AddWithValue("@obydlenost_domu", house.obydlenost_domu);
                command.Parameters.AddWithValue("@rok_vystavby", house.rok_vystavby);
                command.Parameters.AddWithValue("@material_zdi", house.material_zdi);
                command.Parameters.AddWithValue("@pocet_podlazi", house.pocet_podlazi);
                command.ExecuteNonQuery();

                // uzavření připojení k databázi
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool InsertFlats(UserFlats flats)
        {
            dynamic config = Config.GetConfig();
            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
            database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            try
            {
                connection.Open();

                // vytvoření SQL dotazu pro vložení informací o domě do tabulky users_info_houses
                string query = "INSERT INTO users_info_flats (jmeno, obec, cislo_domu, ulice, psc, obydlenost_bytu, velikost_bytu, podlazi_bytu, pocet_lidi) VALUES (@jmeno, @obec, @cislo_domu, @ulice, @psc, @obydlenost_bytu, @velikost_bytu, @podlazi_bytu, @pocet_lidi)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@jmeno", flats.jmeno);
                command.Parameters.AddWithValue("@obec", flats.obec);
                command.Parameters.AddWithValue("@cislo_domu", flats.cislo_domu);
                command.Parameters.AddWithValue("@ulice", flats.ulice);
                command.Parameters.AddWithValue("@psc", flats.psc);
                command.Parameters.AddWithValue("@obydlenost_bytu", flats.obydlenost_bytu);
                command.Parameters.AddWithValue("@velikost_bytu", flats.velikost_bytu);
                command.Parameters.AddWithValue("@podlazi_bytu", flats.podlazi_bytu);
                command.Parameters.AddWithValue("@pocet_lidi", flats.pocet_lidi);
                command.ExecuteNonQuery();

                // uzavření připojení k databázi
                connection.Close();

                return true;
            }
            catch
            {
                return false;
            }
        }

        public List<UserPopulation> GetAllUsers()
        {
            dynamic config = Config.GetConfig();
            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
            List<UserPopulation> users = new List<UserPopulation>();

            try
            {
                connection.Open();

                //vytvoření SQL dotazu pro výběr všech záznamů z tabulky users_info
                string query = "SELECT * FROM users_info";
                MySqlCommand command = new MySqlCommand(query, connection);

                //provedení dotazu a načtení výsledků
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    UserPopulation user = new UserPopulation();
                    user.id = Convert.ToInt32(dataReader["id"]);
                    user.jmeno = dataReader["jmeno"].ToString();
                    user.prijmeni = dataReader["prijmeni"].ToString();
                    user.bydliste = dataReader["bydliste"].ToString();
                    user.nabozenstvi = dataReader["nabozenstvi"].ToString();
                    user.telefonni_cislo = dataReader["telefonni_cislo"].ToString();
                    user.email = dataReader["email"].ToString();
                    user.narodnost = dataReader["narodnost"].ToString();
                    user.statni_obcanstvi = dataReader["statni_obcanstvi"].ToString();
                    user.vzdelani = dataReader["vzdelani"].ToString();
                    users.Add(user);
                }

                //uzavření připojení k databázi
                dataReader.Close();
                connection.Close();
            }
            catch
            {
                // chyba připojení k databázi
            }

            return users;
        }

    }
}
