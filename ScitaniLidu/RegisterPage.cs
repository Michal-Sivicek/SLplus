using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void MainText_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            LoginPage LoginPage = new LoginPage();
            this.Hide();
            LoginPage.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // Zjištění, zda byl checkbox s podmínkami označen
            bool agreedToTerms = checkBoxPodminky.Checked;

            // Ověření, zda byly podmínky přijaty
            if (agreedToTerms)
            {
                // Podmínky byly přijaty - provedení dalších akcí
                // ...
                this.Close();
            }
            else
            {
                // Podmínky nebyly přijaty - zobrazení chybové zprávy
                MessageBox.Show("Musíte souhlasit s podmínkami, abyste mohli pokračovat.");
            }

            // Získání hodnot hesel z textových polí
            string password = firstPassword.Text;
            string confirmPassword = secondPassword.Text;

            // Porovnání hesel
            if (password == confirmPassword)
            {
                // Hesla se shodují - uložení dat a zavření formuláře
                // ...
                this.Close();
            }
            else
            {
                // Hesla se neshodují - zobrazení chybové zprávy
                MessageBox.Show("Hesla se neshodují, zadejte prosím správné heslo.");
            }
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

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
