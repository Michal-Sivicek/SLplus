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
        /// <summary>
        /// Tato metoda (konstruktor) inicializuje komponenty uživatelského rozhraní, jako jsou tlačítka, textová pole, atd.
        /// </summary>
        public MainPage()
        {
            InitializeComponent();
        }

        //Tento příkaz vytváří novou proměnnou typu Form s názvem CurrentForm a přiřazuje jí hodnotu null. 
        Form CurrentForm = null;



        //metoda slouží k otevření nového okna v aplikaci

        /// <summary>
        /// Celá metoda tedy umožňuje jednoduše otevřít novou sekci v hlavním okně aplikace.
        /// Tato metoda slouží k otevření nového okna nebo sekce v hlavním okně aplikace. 
        /// Metoda bere jako parametr instanci Form, která má být otevřena. Nejprve se skryje aktuálně zobrazená Form pomocí metody Hide().
        /// Pak se nastaví proměnná CurrentForm na novou instanci Form. 
        /// Další kroky slouží k tomu, aby nové okno zabralo celou plochu hlavního okna. Nakonec se nová Form přidá na panel2 hlavního okna a zobrazí pomocí metody Show().
        /// </summary>
        /// <param name="Form"></param>
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

        /// <summary>
        /// Zobrazí novou instanci formuláře LoginPage, který slouží k přihlášení uživatele do aplikace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Return_Click(object sender, EventArgs e)
        {
            LoginPage LoginPage = new LoginPage();
            this.Hide();
            LoginPage.Show();
        }

        /// <summary>
        /// Tato metoda slouží pro zavření aplikace, pokud uživatel klikne na křížek v pravém horním rohu okna.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MainPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kontrola, zda uživatel klikl na křížek
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zastavení běhu aplikace
                Application.Exit();
            }
        }


        /// <summary>
        /// Tato metoda slouží k odhlášení uživatele a vrácení na LoginPage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialFlatButton1_Click_1(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
        }

        // Vytvoření nových objektů
        LoginPage loginPage = new LoginPage();
        UserPopulationPage userPopulationPage = new UserPopulationPage();

        //Eventy na otevření nového okna

        /// <summary>
        /// Tato metoda slouží k otevření nové sekce v hlavním okně aplikace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonObyvatelstvo_Click(object sender, EventArgs e)
        {
            OpenSection(userPopulationPage);
        }


        UserHousesPage userHousesPage = new UserHousesPage();

        /// <summary>
        /// Tato metoda slouží k otevření nové sekce v hlavním okně aplikace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonHouse_Click(object sender, EventArgs e)
        {
            OpenSection(userHousesPage);
        }

        UserFlatsPage userFlatsPage= new UserFlatsPage();

        /// <summary>
        /// Tato metoda slouží k otevření nové sekce v hlavním okně aplikace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonFlat_Click(object sender, EventArgs e)
        {
            OpenSection(userFlatsPage);
        }

        Contact contact = new Contact();

        /// <summary>
        /// Tato metoda slouží k otevření nové sekce v hlavním okně aplikace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttoncontact_Click(object sender, EventArgs e)
        {
            OpenSection(contact);
        }

        UserSumPeople userSumPeople= new UserSumPeople();

        /// <summary>
        /// Tato metoda slouží k otevření nové sekce v hlavním okně aplikace.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSecteniUzivatele_Click(object sender, EventArgs e)
        {
            OpenSection(userSumPeople);
        }
    }
}
