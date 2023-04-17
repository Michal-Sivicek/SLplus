using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySqlConnector;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ScitaniLidu
{
    public partial class LoginPage : MaterialSkin.Controls.MaterialForm
    {
        private MySql.Data.MySqlClient.MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        /// <summary>
        /// Tato metoda je konstruktorem třídy LoginPage. Konstruktor je speciální metoda, která se volá při vytváření nové instance třídy.
        /// V této metodě jsou nejprve inicializovány různé vizuální prvky na stránce (např. velikost písma labelů) a následně se načítají údaje z konfiguračního souboru
        /// config.json, který obsahuje informace o připojení k databázi.
        ///Poté se vytvoří připojení k databázi pomocí získaných údajů a nakonec se nastaví klávesová zkratka pro tlačítko "LoginButton".
        /// </summary>
        public LoginPage()
        {
            InitializeComponent();
            // Nastavení velikosti písma Labelu
            LoginText.Font = new Font(LoginText.Font.FontFamily, 20);
            // Nastavení velikosti písma Labelu
            UserName.Font = new Font(UserName.Font.FontFamily, 8);
            // Nastavení velikosti písma Labelu
            Password.Font = new Font(Password.Font.FontFamily, 8);
            //zobrazení hesla 
            LoginPassword.UseSystemPasswordChar = true;

            // Registrace události CheckedChanged pro checkbox 
            ShowPassword.CheckedChanged += new EventHandler(ShowPassword_CheckedChanged);


            dynamic config = Config.GetConfig();
            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;


            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            // Nastavení klávesové zkratky pro tlačítko "LoginButton"
            this.AcceptButton = LoginButton;
        }


        /// <summary>
        /// Tato metoda slouží k ověření, zda bylo zadáno správné uživatelské jméno a heslo a k určení role přihlášeného uživatele. 
        /// Pokud bylo jméno a heslo zadáno správně a uživatel má roli "admin", otevře se stránka pro administrátora.
        /// V opačném případě se otevře hlavní stránka pro běžného uživatele. Pokud se při připojení k databázi vyskytne chyba, zobrazí se chybové hlášení.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Prosím zadejte jmeno a heslo!");
                return;
            }

            try
            {
                connection.Open();

                if (ValidateUser(username, password))
                {
                    string role = GetUserRole(username, password);

                    if (role == null)
                    {
                        MessageBox.Show("Špatně zadané jméno a heslo!");
                    }
                    else if (role == "admin")
                    {
                        ShowAdminPage();
                    }
                    else
                    {
                        ShowMainPage();
                    }
                }
                else
                {
                    MessageBox.Show("Špatně zadané jméno a heslo!");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Tato metoda se pokouší získat počet řádků v tabulce "users", které odpovídají zadané kombinaci uživatelského jména a hesla.

        /// <summary>
        /// Tato metoda slouží ke kontrole platnosti uživatelského jména a hesla pro přihlášení do aplikace.
        /// Metoda provádí SQL dotaz, který ověřuje, zda existuje uživatel s daným uživatelským jménem a heslem v databázi.
        /// Pokud dotaz vrátí počet řádků větší než 0, metoda vrátí hodnotu "true", což znamená, že uživatelské jméno a heslo jsou platné. 
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private bool ValidateUser(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            int count = Convert.ToInt32(command.ExecuteScalar());

            // Pokud je počet řádků větší než 0, pak uživatelské jméno a heslo jsou platné a metoda vrátí hodnotu "true". 
            return (count > 0);
        }

        //metoda provede dotaz do databaze a zsika zaznam s roli uzivatele na zaklade zadaneho jmena a hesla vrati (admin nebo normal)


        /// <summary>
        /// Tato metoda slouží k získání role uživatele na základě jeho uživatelského jména a hesla.
        /// Vytváří se SQL dotaz, který vyhledává v databázi uživatele s daným uživatelským jménem a heslem a vrací jeho roli.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        private string GetUserRole(string username, string password)
        {
            string query = "SELECT role FROM users WHERE username = @username AND password = @password";
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            //Tento příkaz slouží k provedení dotazu na databázi a vrácení hodnoty z prvního sloupce prvního řádku výsledků.
            string role = command.ExecuteScalar()?.ToString();

            return role;
        }

        /// <summary>
        /// Tato metoda skrývá aktuální okno a zobrazuje okno pro správu administrátora (AdminPage).
        /// </summary>
        private void ShowAdminPage()
        {
            AdminPage AdminPage = new AdminPage();
            this.Hide();
            AdminPage.Show();
        }

        /// <summary>
        /// Tato metoda skrývá aktuální okno a zobrazuje okno pro správu uzivatele (MainPage).
        /// </summary>
        private void ShowMainPage()
        {
            MainPage MainPage = new MainPage();
            this.Hide();
            MainPage.Show();
        }

        /// <summary>
        /// Tato metoda reaguje na změny stavu CheckBoxu a přepíná zobrazení textu uživatelského hesla mezi jeho skutečným textem a skrytou podobou (znak hvězdičky).
        /// Pokud je CheckBox zaškrtnutý, nastaví se vlastnost UseSystemPasswordChar na hodnotu false a heslo se zobrazí v běžném textovém tvaru. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (ShowPassword.Checked)
            {
                LoginPassword.UseSystemPasswordChar = false;
            }
            else
            {
                LoginPassword.UseSystemPasswordChar = true;
            }

        }

        /// <summary>
        /// Tato metoda skrývá aktuální okno a zobrazuje okno pro registraci nového uživatele (RegisterPage).
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage RegisterPage = new RegisterPage();
            this.Hide();
            RegisterPage.Show();
        }


        /// <summary>
        /// Tato metoda je událostí, která se spustí, když uživatel zavírá formulář přihlášení.
        /// Metoda kontroluje, zda uživatel klikl na křížek v pravém horním rohu okna, což způsobí uživatelské zavření aplikace. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LoginPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kontrola, zda uživatel klikl na křížek
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zastavení běhu aplikace
                Application.Exit();
            }
        }
    }
}