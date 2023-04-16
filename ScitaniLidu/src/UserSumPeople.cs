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
        /// <summary>
        /// Metoda volá privátní metodu InitializeComponent(), která inicializuje všechny komponenty (tlačítka, textová pole, tabulky atd.)
        /// </summary>
        public UserSumPeople()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Metoda GetNumberOfUsers slouží k získání počtu záznamů v tabulce users_info v databázi.
        /// Nejprve se načítají údaje o připojení k databázi z konfiguračního souboru pomocí metody Config.GetConfig().
        /// Poté se vytvoří spojení s databází a vytvoří se SQL dotaz pro výpočet počtu uživatelů.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metoda GetNumberOfHouses slouží k získání počtu záznamů v tabulce users_info_houses v databázi.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Metoda GetNumberOfFlats slouží k získání počtu záznamů v tabulce users_info_flats v databázi.
        /// </summary>
        /// <returns></returns>
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

        /// <summary>
        /// Tato metoda po kliknutí na tlačítko spočítá počet uživatelů v databázi a vypíše ho na label.
        /// Pokud dojde k chybě při připojování k databázi, vypíše se na label zpráva o chybě.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            int count = GetNumberOfUsers();
            label1.Text = "Sečtené obyvatelstvo: " + count.ToString();
        }

        /// <summary>
        /// Tato metoda slouží ke zjištění počtu vlastněných domů v databázi a zobrazí ho v labelu.
        /// Po kliknutí na tlačítko "button2" se spustí metoda "GetNumberOfHouses()",
        /// která vrací počet domů z tabulky "houses". Tento počet se následně zobrazí v labelu "label2".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            int count = GetNumberOfHouses();
            label2.Text = "Sečtený počet vlastněných domů: " + count.ToString();
            
        }

        /// <summary>
        /// Tato metoda  vytváří tlačítko "button3", které po kliknutí spočítá počet vlastněných bytů pomocí funkce "GetNumberOfHouses" 
        /// a zobrazí výsledek v popisku "label3".
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            int count = GetNumberOfHouses();
            label3.Text = "Sečtený počet vlastněných bytů: " + count.ToString();
        }
    }
}
