﻿using Microsoft.VisualBasic.ApplicationServices;
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


        /// <summary>
        /// Metoda pro vložení uživatele do databáze
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>
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
                string query = "INSERT INTO users_info (jmeno, prijmeni, bydliste, datum_narozeni, telefonni_cislo, email, narodnost, statni_obcanstvi, vzdelani) VALUES (@jmeno, @prijmeni, @bydliste, @datum_narozeni, @telefonni_cislo, @email, @narodnost, @statni_obcanstvi, @vzdelani)";
                MySqlCommand command = new MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@jmeno", user.jmeno);
                command.Parameters.AddWithValue("@prijmeni", user.prijmeni);
                command.Parameters.AddWithValue("@bydliste", user.bydliste);
                command.Parameters.AddWithValue("@datum_narozeni", user.datum_narozeni);
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
        /// <summary>
        /// Metoda pro vložení domu do databáze
        /// </summary>
        /// <param name="house"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Metoda pro vložení bytu do databáze
        /// </summary>
        /// <param name="flats"></param>
        /// <returns></returns>
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

        /// <summary>
        /// Tato metoda slouží k získání všech uživatelů ze databáze.
        /// Nejprve načte konfiguraci připojení k databázi z konfiguračního souboru pomocí třídy Config. 
        /// </summary>
        /// <returns></returns>
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
                string query = "SELECT jmeno, prijmeni, bydliste, datum_narozeni, telefonni_cislo, email, narodnost, statni_obcanstvi, vzdelani FROM users_info;";
                MySqlCommand command = new MySqlCommand(query, connection);

                //provedení dotazu a načtení výsledků
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    UserPopulation user = new UserPopulation();
                    user.jmeno = dataReader["jmeno"].ToString();
                    user.prijmeni = dataReader["prijmeni"].ToString();
                    user.bydliste = dataReader["bydliste"].ToString();
                    user.datum_narozeni = dataReader["datum_narozeni"].ToString();
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

        /// <summary>
        /// Tato metoda slouží k získání všech záznamů o domácnostech z databáze a jejich zobrazení v aplikaci. 
        /// Připojí se k databázi pomocí konfiguračních údajů, které načte z JSON souboru, a pak provede SQL dotaz na získání všech záznamů z tabulky user_houses. 
        /// </summary>
        /// <returns></returns>
        public List<UserHouse> GetAllUserHouses()
        {
            dynamic config = Config.GetConfig();
            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            List<UserHouse> userHouses = new List<UserHouse>();

            try
            {
                connection.Open();

                //vytvoření SQL dotazu pro výběr všech záznamů z tabulky user_houses
                string query = "SELECT jmeno_prijmeni, obec, cislo_domu, ulice, psc, obydlenost_domu, rok_vystavby, material_zdi, pocet_podlazi FROM users_info_houses;";
                MySqlCommand command = new MySqlCommand(query, connection);

                //provedení dotazu a načtení výsledků
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    UserHouse userHouse = new UserHouse();
                    userHouse.jmeno_prijmeni = dataReader["jmeno_prijmeni"].ToString();
                    userHouse.obec = dataReader["obec"].ToString();
                    userHouse.cislo_domu = dataReader["cislo_domu"].ToString();
                    userHouse.ulice = dataReader["ulice"].ToString();
                    userHouse.psc = dataReader["psc"].ToString();
                    userHouse.obydlenost_domu = dataReader["obydlenost_domu"].ToString();
                    userHouse.rok_vystavby = dataReader["rok_vystavby"].ToString();
                    userHouse.material_zdi = dataReader["material_zdi"].ToString();
                    userHouse.pocet_podlazi = dataReader["pocet_podlazi"].ToString();
                    userHouses.Add(userHouse);
                }

                //uzavření připojení k databázi
                dataReader.Close();
                connection.Close();
            }
            catch
            {
                // chyba připojení k databázi
            }

            return userHouses;
        }

        /// <summary>
        /// Tato metoda slouží k získání všech záznamů o bytových jednotkách uložených v databázi. 
        /// Nejprve načte konfiguraci databáze z konfiguračního souboru, poté se připojí k databázi a provede SQL dotaz na výběr všech záznamů z tabulky users_info_flats.
        /// </summary>
        /// <returns></returns>
        public List<UserFlats> GetAllUserFlats()
        {
            dynamic config = Config.GetConfig();
            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            MySqlConnection connection = new MySqlConnection(connectionString);
            List<UserFlats> userFlats = new List<UserFlats>();

            try
            {
                connection.Open();

                // vytvoření SQL dotazu pro výběr všech záznamů z tabulky users_info_flats
                string query = "SELECT jmeno, obec, cislo_domu, ulice, psc, obydlenost_bytu, velikost_bytu, podlazi_bytu, pocet_lidi FROM users_info_flats";
                MySqlCommand command = new MySqlCommand(query, connection);

                // provedení dotazu a načtení výsledků
                MySqlDataReader dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    UserFlats userFlat = new UserFlats();
                    userFlat.jmeno = dataReader["jmeno"].ToString();
                    userFlat.obec = dataReader["obec"].ToString();
                    userFlat.cislo_domu = dataReader["cislo_domu"].ToString();
                    userFlat.ulice = dataReader["ulice"].ToString();
                    userFlat.psc = dataReader["psc"].ToString();
                    userFlat.obydlenost_bytu = dataReader["obydlenost_bytu"].ToString();
                    userFlat.velikost_bytu = dataReader["velikost_bytu"].ToString();
                    userFlat.podlazi_bytu = dataReader["podlazi_bytu"].ToString();
                    userFlat.pocet_lidi = dataReader["pocet_lidi"].ToString();
                    userFlats.Add(userFlat);
                }

                // uzavření připojení k databázi
                dataReader.Close();
                connection.Close();
            }
            catch
            {
                // chyba připojení k databázi
            }

            return userFlats;
        }
    }
}
