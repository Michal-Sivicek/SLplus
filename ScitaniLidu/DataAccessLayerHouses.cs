using MySql.Data.MySqlClient;

namespace ScitaniLidu
{
    public class DataAccessLayerHouses
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

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
    }
}
