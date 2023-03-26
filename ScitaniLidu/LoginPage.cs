using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySqlConnector;
using System.Diagnostics;
using Newtonsoft.Json;

namespace ScitaniLidu
{
    public partial class LoginPage : Form
    {
        private MySql.Data.MySqlClient.MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;


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

            // Registrace události CheckedChanged pro checkbox "Ukázat heslo"
            ShowPassword.CheckedChanged += new EventHandler(ShowPassword_CheckedChanged);

            string json = File.ReadAllText("C:\\Users\\Admin\\source\\repos\\ScitaniLidu\\ScitaniLidu\\config.json");
            dynamic config = JsonConvert.DeserializeObject(json);

            string server = config.server;
            string database = config.database;
            string uid = config.uid;
            string password = config.password;

            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            // Nastavení klávesové zkratky pro tlaèítko "LoginButton"
            this.AcceptButton = LoginButton;
        }

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

        private void ShowAdminPage()
        {
            AdminPage AdminPage = new AdminPage();
            this.Hide();
            AdminPage.Show();
        }

        private void ShowMainPage()
        {
            MainPage MainPage = new MainPage();
            this.Hide();
            MainPage.Show();
        }

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

        private void register_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterPage RegisterPage = new RegisterPage();
            this.Hide();
            RegisterPage.Show();

        }

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