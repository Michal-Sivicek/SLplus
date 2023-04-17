using Google.Protobuf.WellKnownTypes;
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
        /// <summary>
        /// Tato metoda inicializuje všechny komponenty formuláře, včetně grafických prvků a událostí.
        /// </summary>
        public AdminPage()
        {
            InitializeComponent();
        }

        //Tento příkaz vytváří proměnnou CurrentForm typu Form a inicializuje ji na hodnotu null.
        Form CurrentForm = null;

        /// <summary>
        /// Tato metoda slouží k otevření nového formuláře v panelu panel2 v rámci stávajícího formuláře.
        ///Při volání této metody se jako parametr předává instance formuláře, který se má otevřít.V metodě se nejprve zkontroluje,
        ///zda v panelu panel2 již není otevřen jiný formulář(tj.zda není proměnná CurrentForm různá od null), pokud ano, skryje se pomocí metody Hide().
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
        /// Tato metoda je určena k zajištění správného ukončení aplikace, když uživatel klikne na tlačítko "X" na formuláři.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminPage_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Kontrola, zda uživatel klikl na křížek
            if (e.CloseReason == CloseReason.UserClosing)
            {
                // Zastavení běhu aplikace
                Application.Exit();
            }
        }

        //vytvoření nového objektu
        AdminPopulationPage adminPopulationPage = new AdminPopulationPage();

        //Eventy na otevření nového okna

        /// <summary>
        /// Tato metoda je událostní metodou, která se spustí po kliknutí na tlačítko vypisObyvatelstva na formuláři.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vypisObyvatelstva_Click(object sender, EventArgs e)
        {
            OpenSection(adminPopulationPage);
        }


        AdminHousesPage adminHousesPage = new AdminHousesPage();

        /// <summary>
        /// Tato metoda je událostní metodou, která se spustí po kliknutí na tlačítko vypisObyvatelstva na formuláři.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vypisDomu_Click(object sender, EventArgs e)
        {
            OpenSection(adminHousesPage);
        }

        AdminFlatsPage adminFlatsPage = new AdminFlatsPage();
        /// <summary>
        /// Tato metoda je událostní metodou, která se spustí po kliknutí na tlačítko vypisObyvatelstva na formuláři.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void vypisBytu_Click(object sender, EventArgs e)
        {
            OpenSection(adminFlatsPage);
        }

        /// <summary>
        /// Tato metoda je událostní metodou, která se spustí po kliknutí na tlačítko materialFlatButton1 na formuláři.
        /// Tato metoda se vrátí na přihlašovací stránku.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            LoginPage loginPage = new LoginPage();
            this.Hide();
            loginPage.ShowDialog();
        }
    }
}
