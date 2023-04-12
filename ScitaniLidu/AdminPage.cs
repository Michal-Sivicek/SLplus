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
    public partial class AdminPage : MaterialSkin.Controls.MaterialForm
    {
        public AdminPage()
        {
            InitializeComponent();
        }

        Form CurrentForm = null;
        //metoda slouží k otevření nového okna v aplikaci
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

        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kontrola, zda uživatel klikl na křížek
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zastavení běhu aplikace
                Application.Exit();
            }
        }
        AdminPopulationPage adminPopulationPage = new AdminPopulationPage();
        //Eventy na otevření nového okna
        private void vypisObyvatelstva_Click(object sender, EventArgs e)
        {
            OpenSection(adminPopulationPage);
        }
    }
}
