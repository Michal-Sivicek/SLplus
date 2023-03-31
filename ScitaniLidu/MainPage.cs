using MaterialSkin;
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

    public partial class MainPage : MaterialSkin.Controls.MaterialForm
    {
        public MainPage()
        {
            InitializeComponent();

        }


        Form CurrentForm = null;

        public void OpenSection(Form Form)
        {
            if (CurrentForm != null)
                CurrentForm.Hide();

            CurrentForm = Form;
            Form.TopLevel = false;
            Form.FormBorderStyle = FormBorderStyle.None;
            Form.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(Form);
            Form.Show();
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

        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
        }

        private void panelMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        LoginPage loginPage = new LoginPage();
        private void buttonObyvatelstvo_Click(object sender, EventArgs e)
        {
            OpenSection(loginPage);
        }
    }
}
