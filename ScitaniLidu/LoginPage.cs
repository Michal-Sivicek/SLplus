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
            UserName.Font = new Font(UserName.Font.FontFamily, 11);
            // Nastaven� velikosti p�sma Labelu
            Password.Font = new Font(Password.Font.FontFamily, 11);
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
        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Pros�m zadejte jmeno a heslo!");
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
                            MessageBox.Show("�patn� zadan� jm�no a heslo!");
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
                        MessageBox.Show("�patn� zadan� jm�no a heslo!");
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
            // Kontrola, zda u�ivatel klikl na k��ek
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zastaven� b�hu aplikace
                Application.Exit();
            }
        }
    }
}