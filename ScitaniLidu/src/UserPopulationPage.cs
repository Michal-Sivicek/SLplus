using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScitaniLidu
{
    public partial class UserPopulationPage : Form
    {
        public UserPopulationPage()
        {
            InitializeComponent();
            this.AcceptButton = sendButton; //nastavení klávesové zkratky na enter
            checkBoxGDPR.CheckedChanged += new EventHandler(checkBoxGDPR_CheckedChanged);
            sendButton.Enabled = false; //tlačítko odeslat je na začátku neaktivní                                 
        }

        private void checkBoxGDPR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGDPR.Checked == true)
            {
                sendButton.Enabled = true; //povolí tlačítko odeslat, pokud je CheckBox označen
            }
            else
            {
                sendButton.Enabled = false; //neaktivní, pokud CheckBox není označen
            }
        }

        private void sendButton_Click_1(object sender, EventArgs e)
        {
            // Kontrola, zda jsou všechny textové pole a datum narození vyplněny a byla vybrána alespoň jedna položka v checkedListBoxEducation
            if (usernameTextBox.Text == "" || lastnameTextBox.Text == "" || adressTextBox.Text == "" || dateTimePicker1.Value == DateTimePicker.MinimumDateTime || textBoxPhoneNumber.Text == "" || textBoxEmail.Text == "" || textBoxNationality.Text == "" || textBoxCitizenShip.Text == "" || checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Všechna pole musí být vyplněna a musí být vybrána alespoň jedna položka vzdělání.");
                return;
            }


            //získání dat z textových polí a kontrolních prvků
            string jmeno = Regex.Replace(usernameTextBox.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ]+", "");

            //ověření, zda jméno obsahuje pouze písmena
            if (jmeno.Length != usernameTextBox.Text.Length)
            {
                MessageBox.Show("Jméno musí obsahovat pouze písmena.");
                return; // ukončí metodu bez uložení dat do databáze
            }
            string prijmeni = Regex.Replace(lastnameTextBox.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ]+", "");

            if (prijmeni.Length != lastnameTextBox.Text.Length)
            {
                MessageBox.Show("Příjmení musí obsahovat pouze písmena.");
                return;
            }

            string bydliste = Regex.Replace(adressTextBox.Text, @"[^a-zA-Z0-9/ ]+", "");

            if (bydliste.Length != adressTextBox.Text.Length)
            {
                MessageBox.Show("Bydliště musí obsahovat pouze písmena, čísla, lomítka.");
                return;
            }

            string datum_narozeni = dateTimePicker1.Value.ToString("dd.MM.yyyy");
            Regex datum_regex = new Regex(@"^\d{2}\.\d{2}\.\d{4}$");

            if (!datum_regex.IsMatch(datum_narozeni))
            {
                MessageBox.Show("Datum narození musí být ve formátu dd.mm.yyyy.");
                return;
            }



            string telefonni_cislo = Regex.Replace(textBoxPhoneNumber.Text, @"[^0-9 +]+", "");

            if (telefonni_cislo.Length != textBoxPhoneNumber.Text.Length)
            {
                MessageBox.Show("Telefonní číslo musí obsahovat pouze čísla.");
                return;
            }

            string email = Regex.Replace(textBoxEmail.Text, @"[^a-zA-Z0-9@._-]+", "");

            if (email.Length != textBoxEmail.Text.Length || !email.Contains("@")) //povinny znak "@"
            {
                MessageBox.Show("Email musí obsahovat pouze písmena, čísla, @, ., - a _ a musí obsahovat znak @.");
                return;
            }

            string narodnost = Regex.Replace(textBoxNationality.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ]+", "");

            if (narodnost.Length != textBoxNationality.Text.Length)
            {
                MessageBox.Show("Národnost musí obsahovat pouze písmena a mezery.");
                return;
            }

            string statni_obcanstvi = Regex.Replace(textBoxCitizenShip.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ]+", "");

            if (statni_obcanstvi.Length != textBoxCitizenShip.Text.Length)
            {
                MessageBox.Show("Státní občanství musí obsahovat pouze písmena a mezery.");
                return;
            }

            // Kontrola vzdělání
            string vzdelani = "";
            foreach (object item in checkedListBox1.CheckedItems)
            {
                vzdelani += item.ToString() + ", "; // Přidání vybrané položky do řetězce
            }
            vzdelani = vzdelani.TrimEnd(',', ' '); // Odstranění poslední čárky a mezery

            if (vzdelani != "základní škola" && vzdelani != "střední škola" && vzdelani != "vysoká škola")
            {
                MessageBox.Show("Vzdělání musí být uvedeno jako 'základní škola', 'střední škola' nebo 'vysoká škola'.");
                return;
            }


            //předání dat do vrstvy business logiky
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            bool result = BLL.InsertUser(jmeno, prijmeni, bydliste, datum_narozeni, telefonni_cislo, email, narodnost, statni_obcanstvi, vzdelani);

            //zpracování výsledku a vypsání informací uživateli
            if (result == true)
            {
                MessageBox.Show("Data byla úspěšně uložena do databáze.");
            }
            else
            {
                MessageBox.Show("Nastala chyba při ukládání dat do databáze.");
            }

            // Odstranění dat po úspěšném uložení do databáze
            usernameTextBox.Clear();
            lastnameTextBox.Clear();
            adressTextBox.Clear();
            dateTimePicker1.Value = DateTimePicker.MinimumDateTime; // Přidána nová řádka pro vynulování dateTimePicker1
            textBoxPhoneNumber.Clear();
            textBoxEmail.Clear();
            textBoxNationality.Clear();
            textBoxCitizenShip.Clear();
            checkedListBox1.ClearSelected(); // Přidána nová řádka pro odznačení položek v checkedListBoxEducation
        }

        private void linkLabelGDPR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.uoou.cz/obecne-narizeni-o-ochrane-osobnich-udaju-gdpr/ds-3938/p1=3938") { UseShellExecute = true });
        }
    }
}