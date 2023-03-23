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
            // Nastavení velikosti písma Labelu
            LoginText.Font = new Font(LoginText.Font.FontFamily, 20);
            // Nastavení velikosti písma Labelu
            UserName.Font = new Font(UserName.Font.FontFamily, 11);
            // Nastavení velikosti písma Labelu
            Password.Font = new Font(Password.Font.FontFamily, 11);
            //zobrazení hesla 
            LoginPassword.UseSystemPasswordChar= true;

            // Registrace události CheckedChanged pro checkbox "Ukázat heslo"
            ShowPassword.CheckedChanged += new EventHandler(ShowPassword_CheckedChanged);

            server = "37.120.169.246";
            database = "loginScitaniLidu";
            uid = "michal30";
            password = "xgamerx";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Prosím zadejte jmeno a heslo!");
            }
            else
            {
                try
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM users WHERE username = @username AND password = @password";
                    MySql.Data.MySqlClient.MySqlCommand command = new MySql.Data.MySqlClient.MySqlCommand(query, connection);

                    command.Parameters.AddWithValue("@username", username);
                    command.Parameters.AddWithValue("@password", password);
                    int count = Convert.ToInt32(command.ExecuteScalar());

                    if (count > 0)
                    {
                        query = "SELECT role FROM users WHERE username = @username AND password = @password";
                        command = new MySql.Data.MySqlClient.MySqlCommand(query, connection);

                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        string role = command.ExecuteScalar()?.ToString(); //metoda ExecuteScalar provede dotaz na databazi a vrati hodnotu admin/normal, pouziti ToSring kvuli hodnote null

                        if (role == null)
                        {
                            MessageBox.Show("Špatnì zadané jméno a heslo!");
                        }
                        else if (role == "admin")
                        {
                            AdminPage AdminPage = new AdminPage();
                            this.Hide();
                            AdminPage.Show();
                        }
                        else
                        {
                            MainPage MainPage = new MainPage();
                            this.Hide();
                            MainPage.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Špatnì zadané jméno a heslo!");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
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
            // Kontrola, zda uživatel klikl na køížek
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zastavení bìhu aplikace
                Application.Exit();
            }
        }
    }
}