using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ScitaniLidu
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
            // Nastavení velikosti písma Labelu
            MainText.Font = new Font(MainText.Font.FontFamily, 20);
            //zobrazení hesla 
            firstPassword.UseSystemPasswordChar = true;
            secondPassword.UseSystemPasswordChar = true;
            linkLabel1.LinkColor = Color.Blue;
            // Nastavení vlastnosti Text pro zobrazení textu odkazu
            linkLabel1.Text = "Podmínky";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginPage LoginPage = new LoginPage();
            this.Hide();
            LoginPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ValidateAgreedToTerms() && ValidateUserInput())
            {
                MessageBox.Show("Registrace proběhlá úspěšně");
                SaveDataAndLoginPage();
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
    }
}
