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

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateAgreedToTerms() && ValidateUserInput())
            {
                SaveDataAndLoginPage();
                MessageBox.Show("Registrace proběhla úspěšně");
            }
        }

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

        private void RegisterPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kontrola, zda uživatel klikl na křížek
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zastavení běhu aplikace
                Application.Exit();
            }
        }
       
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.google.com") { UseShellExecute = true });
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
            this.Show();
        }
    }
}
