using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using MySqlConnector;
using Newtonsoft.Json;

namespace ScitaniLidu
{
    public partial class RegisterPage : MaterialSkin.Controls.MaterialForm
    {
        private MySql.Data.MySqlClient.MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string passwordDatabase;
        private string connectionString;


        /// <summary>
        /// Tato metoda slouží k inicializaci objektu třídy RegisterPage. Při vytvoření instance této třídy jsou v ní provedeny různé operace,
        /// jako například skrytí hesla, načtení konfigurace z JSON souboru a nastavení klávesové zkratky pro tlačítko registrace. 
        /// Dále je inicializována proměnná pro připojení k databázi a vytvoření odpovídajícího řetězce připojení.
        /// </summary>
        public RegisterPage()
        {
            InitializeComponent();
            //zobrazení hesla 
            firstPassword.UseSystemPasswordChar = true;
            secondPassword.UseSystemPasswordChar = true;
            linkLabel1.LinkColor = Color.Blue;

            // Nastavení vlastnosti Text pro zobrazení textu odkazu
            linkLabel1.Text = "Podmínky";

            // Načtení konfigurace z JSON souboru
            dynamic config = Config.GetConfig();

            server = config.server;
            database = config.database;
            uid = config.uid;
            passwordDatabase = config.password;

            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + passwordDatabase + ";";

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            // Nastavení klávesové zkratky pro tlačítko registrace
            this.AcceptButton = registerButton;
        }


        /// <summary>
        /// Tato metoda reaguje na kliknutí na tlačítko "Register" a volá další metody pro ověření, zda uživatel souhlasil s podmínkami
        /// a zda zadal správné údaje do registračního formuláře. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateAgreedToTerms() && ValidateUserInput())
            {
                SaveDataAndLoginPage();
                MessageBox.Show("Registrace proběhla úspěšně");
            }
        }

        /// <summary>
        /// Tato metoda slouží k ověření, zda uživatel souhlasil s podmínkami, například při registraci nebo používání služeb aplikace.
        /// Pokud uživatel nesouhlasil, metoda zobrazí chybovou zprávu a vrátí hodnotu false, jinak vrátí hodnotu true.
        /// </summary>
        /// <returns></returns>
        private bool ValidateAgreedToTerms()
        {
            bool agreedToTerms = checkBoxPodminky.Checked;

            if (!agreedToTerms)
            {
                // Podmínky nebyly přijaty - zobrazení chybové zprávy
                MessageBox.Show("Musíte souhlasit s podmínkami, abyste mohli pokračovat.");
                return false;
            }
            return true;
        }

        /// <summary>
        /// Tato metoda slouží k validaci uživatelského vstupu při registraci nového uživatele. 
        /// Kontroluje, zda bylo zadáno uživatelské jméno a heslo, a zda se heslo shoduje s jeho potvrzením. 
        /// Pokud některá z těchto podmínek není splněna, zobrazí se chybová zpráva a metoda vrátí hodnotu false, jinak vrátí hodnotu true.
        /// </summary>
        /// <returns></returns>
        private bool ValidateUserInput()
        {
            string password = firstPassword.Text;
            string confirmPassword = secondPassword.Text;
            string username = registerUsername.Text;

            if (string.IsNullOrEmpty(username))
            {
                MessageBox.Show("Zadejte prosím uživatelské jméno.");
                return false;
            }

            if (string.IsNullOrEmpty(password) || string.IsNullOrEmpty(confirmPassword))
            {
                MessageBox.Show("Zadejte prosím heslo a potvrzení hesla.");
                return false;
            }

            if (password != confirmPassword)
            {
                MessageBox.Show("Hesla se neshodují, zadejte prosím správné heslo.");
                return false;
            }
            return true;
        }


        /// <summary>
        /// Tato metoda slouží k uložení nově zaregistrovaného uživatele do databáze a následnému přesměrování na stránku pro přihlášení.
        /// Nejprve získává uživatelské jméno a heslo z textových polí na stránce pro registraci.
        /// Poté se vytváří dotaz pro vložení nového uživatele do tabulky "users" s rolí "normal". 
        /// </summary>
        private void SaveDataAndLoginPage()
        {
            
            string username = registerUsername.Text;
            string password = firstPassword.Text;

            // Vložení nového uživatele s rolí "normal" do tabulky "users"
            string query = "INSERT INTO users (username, password, role) VALUES (@Username, @Password, 'normal')";

            using (MySql.Data.MySqlClient.MySqlConnection connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString))
            {
                MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, connection);
                command.Parameters.AddWithValue("@Username", username);
                command.Parameters.AddWithValue("@Password", password);

                connection.Open();
                command.ExecuteNonQuery();
            }

            LoginPage LoginPage = new LoginPage();
            this.Hide();
            LoginPage.Show();
        }


        /// <summary>
        /// Tato metoda slouží k obsluze události FormClosing, která se spustí při zavírání formuláře.
        /// Metoda kontroluje, zda uživatel zavírá formulář kliknutím na křížek. Pokud ano, metoda zastaví běh aplikace voláním metody Application.Exit().
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RegisterPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kontrola, zda uživatel klikl na křížek
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zastavení běhu aplikace
                Application.Exit();
            }
        }

        /// <summary>
        /// Tato metoda otevře webovou stránku s podmínkami pro sčítání lidu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.czso.cz/csu/scitani2021/zakon-o-scitani-2021") { UseShellExecute = true });
        }

        /// <summary>
        /// Tato metoda přechází na stránku přihlášení (LoginPage) a skrývá aktuální stránku (RegisterPage).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
        }
    }
}
