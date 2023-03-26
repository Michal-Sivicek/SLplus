using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using MySqlConnector;
using System.Diagnostics;

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
            // Nastaven� velikosti p�sma Labelu
            LoginText.Font = new Font(LoginText.Font.FontFamily, 20);
            // Nastaven� velikosti p�sma Labelu
            UserName.Font = new Font(UserName.Font.FontFamily, 8);
            // Nastaven� velikosti p�sma Labelu
            Password.Font = new Font(Password.Font.FontFamily, 8);
            //zobrazen� hesla 
            LoginPassword.UseSystemPasswordChar= true;

            // Registrace ud�losti CheckedChanged pro checkbox "Uk�zat heslo"
            ShowPassword.CheckedChanged += new EventHandler(ShowPassword_CheckedChanged);

            server = "37.120.169.246";
            database = "loginScitaniLidu";
            uid = "michal30";
            password = "xgamerx";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);

            // Nastaven� kl�vesov� zkratky pro tla��tko "LoginButton"
            this.AcceptButton = LoginButton;
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Pros�m zadejte jmeno a heslo!");
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
                        MessageBox.Show("�patn� zadan� jm�no a heslo!");
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
                    MessageBox.Show("�patn� zadan� jm�no a heslo!");
                }

                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        //Tato metoda se pokou�� z�skat po�et ��dk� v tabulce "users", kter� odpov�daj� zadan� kombinaci u�ivatelsk�ho jm�na a hesla.
        private bool ValidateUser(string username, string password)
        {
            string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            int count = Convert.ToInt32(command.ExecuteScalar());

            // Pokud je po�et ��dk� v�t�� ne� 0, pak u�ivatelsk� jm�no a heslo jsou platn� a metoda vr�t� hodnotu "true". 
            return (count > 0);
        }

        //metoda provede dotaz do databaze a zsika zaznam s roli uzivatele na zaklade zadaneho jmena a hesla vrati (admin nebo normal)
        private string GetUserRole(string username, string password)
        {
            string query = "SELECT role FROM users WHERE username = @username AND password = @password";
            MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, connection);

            command.Parameters.AddWithValue("@username", username);
            command.Parameters.AddWithValue("@password", password);
            //Tento p��kaz slou�� k proveden� dotazu na datab�zi a vr�cen� hodnoty z prvn�ho sloupce prvn�ho ��dku v�sledk�.
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
            // Kontrola, zda u�ivatel klikl na k��ek
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zastaven� b�hu aplikace
                Application.Exit();
            }
        }
    }
}