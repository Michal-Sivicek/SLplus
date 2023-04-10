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
    public partial class UserPopulationPage : Form
    {
        public UserPopulationPage()
        {
            InitializeComponent();
        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            //získání dat z textových polí a kontrolních prvků
            string jmeno = usernameTextBox.Text;
            string prijmeni = lastnameTextBox.Text;
            string bydliste = adressTextBox.Text;
            string nabozenstvi = textBoxReligion.Text;
            string telefonni_cislo = textBoxPhoneNumber.Text;
            string email = textBoxEmail.Text;
            string narodnost = textBoxNationality.Text;
            string statni_obcanstvi = textBoxCitizenShip.Text;
            string vzdelani = textBoxEdjucation.Text;
            //předání dat do vrstvy business logiky
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            bool result = BLL.InsertUser(jmeno, prijmeni, bydliste, nabozenstvi, telefonni_cislo, email, narodnost, statni_obcanstvi, vzdelani);

            //zpracování výsledku a vypsání informací uživateli
            if (result == true)
            {
                MessageBox.Show("Data byla úspěšně uložena do databáze.");
            }
            else
            {
                MessageBox.Show("Nastala chyba při ukládání dat do databáze.");
            }
        }
    }
}


