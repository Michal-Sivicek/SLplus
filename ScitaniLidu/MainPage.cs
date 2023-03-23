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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            // Nastavení velikosti písma Labelu
            MainText.Font = new Font(MainText.Font.FontFamily, 12);
        }

        private void Return_Click(object sender, EventArgs e)
        {
            LoginPage LoginPage = new LoginPage();
            this.Hide();
            LoginPage.Show();
        }

        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
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
