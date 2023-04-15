using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScitaniLidu
{
    public partial class UserSumPeople : Form
    {
        public UserSumPeople()
        {
            InitializeComponent();
        }

        private int GetNumberOfUsers()
        {
            dynamic config = Config.GetConfig();
            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            int count = 0;

            try
            {
                connection.Open();

                // vytvoření SQL dotazu pro výpočet počtu uživatelů
                string query = "SELECT COUNT(*) as pocet_vyplneni FROM users_info";
                MySqlCommand command = new MySqlCommand(query, connection);

                // provedení dotazu a načtení výsledku
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    count = Convert.ToInt32(dataReader["pocet_vyplneni"]);
                }

                // uzavření připojení k databázi
                dataReader.Close();
                connection.Close();
            }
            catch
            {
                // chyba připojení k databázi
            }

            return count;
        }

        private int GetNumberOfHouses()
        {
            dynamic config = Config.GetConfig();
            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            int count = 0;

            try
            {
                connection.Open();

                // vytvoření SQL dotazu pro výpočet počtu uživatelů
                string query = "SELECT COUNT(*) as pocet_vyplneni FROM users_info_houses";
                MySqlCommand command = new MySqlCommand(query, connection);

                // provedení dotazu a načtení výsledku
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    count = Convert.ToInt32(dataReader["pocet_vyplneni"]);
                }

                // uzavření připojení k databázi
                dataReader.Close();
                connection.Close();
            }
            catch
            {
                // chyba připojení k databázi
            }

            return count;
        }

        private int GetNumberOfFlats()
        {
            dynamic config = Config.GetConfig();
            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            int count = 0;

            try
            {
                connection.Open();

                // vytvoření SQL dotazu pro výpočet počtu uživatelů
                string query = "SELECT COUNT(*) as pocet_vyplneni FROM users_info_flats";
                MySqlCommand command = new MySqlCommand(query, connection);

                // provedení dotazu a načtení výsledku
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    count = Convert.ToInt32(dataReader["pocet_vyplneni"]);
                }

                // uzavření připojení k databázi
                dataReader.Close();
                connection.Close();
            }
            catch
            {
                // chyba připojení k databázi
            }

            return count;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int count = GetNumberOfUsers();
            label1.Text = "Sečtené obyvatelstvo: " + count.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int count = GetNumberOfHouses();
            label2.Text = "Sečtený počet vlastněných domů: " + count.ToString();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int count = GetNumberOfHouses();
            label3.Text = "Sečtený počet vlastněných bytů: " + count.ToString();
        }
    }
}
