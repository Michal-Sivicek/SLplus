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

            server = "127.0.0.1";
            database = "loginScitaniLidu";
            uid = "root";
            password = "";
            string connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySql.Data.MySqlClient.MySqlConnection(connectionString);
        }


        private void LoginText_Click(object sender, EventArgs e)
        {

        }

        private void fileSystemWatcher1_Changed(object sender, FileSystemEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            string username = LoginUsername.Text;
            string password = LoginPassword.Text;

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter username and password!");
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
                        MessageBox.Show("Login successful!");
                        // Vytvoøení nové instance druhého okna
                        MainPage mainForm = new MainPage();
                        // Skrytí aktuálního okna
                        this.Hide();
                        // Zobrazení druhého okna
                        mainForm.Show();
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }

                    connection.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

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
    }
}