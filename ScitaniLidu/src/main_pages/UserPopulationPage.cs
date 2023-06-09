﻿using System;
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
        /// <summary>
        /// Metoda nastavuje klávesovou zkratku pro tlačítko "Odeslat" na Enter, takže uživatelé mohou rychleji odesílat data. 
        /// pro událost změny stavu zaškrtávacího políčka GDPR, které uživatelé musí označit, aby mohli odeslat svá data. 
        /// Pokud uživatel označí políčko GDPR, tlačítko pro odeslání dat se povolí,
        /// takže uživatelé mohou odeslat svá data. Na začátku je tlačítko pro odeslání dat neaktivní, dokud uživatel neoznačí políčko GDPR.
        /// </summary>
        public UserPopulationPage()
        {
            InitializeComponent();
            this.AcceptButton = sendButton; //nastavení klávesové zkratky na enter
            checkBoxGDPR.CheckedChanged += new EventHandler(checkBoxGDPR_CheckedChanged);
            sendButton.Enabled = false; //tlačítko odeslat je na začátku neaktivní                                 
        }

        /// <summary>
        /// Tento kód řídí chování tlačítka "Odeslat" na stránce pro zadávání informací o uživateli v závislosti na stavu zaškrtávacího políčka GDPR.
        /// Pokud je checkbox označen, tlačítko "Odeslat" je povoleno a může být použito k odeslání formuláře,
        /// pokud není checkbox označen, tlačítko je neaktivní a uživatel nemůže odeslat formulář.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// Na začátku metody se kontroluje, zda jsou všechny textová pole a datum narození vyplněny a zda byla vybrána alespoň jedna položka v checkedListBoxEducation.
        /// Pokud některá z podmínek není splněna, zobrazí se uživateli chybové hlášení a metoda se ukončí.
        /// Poté jsou získána data z textových polí a kontrolních prvků a zkontrolována na platnost.
        /// Pokud jsou data neplatná, metoda se ukončí a uživateli se zobrazí chybové hlášení.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void sendButton_Click_1(object sender, EventArgs e)
        {
            // Kontrola, zda jsou všechny textové pole a datum narození vyplněny a byla vybrána alespoň jedna položka v checkedListBoxEducation
            if (usernameTextBox.Text == "" || lastnameTextBox.Text == "" || adressTextBox.Text == "" || dateTimePicker1.Value == DateTimePicker.MinimumDateTime || textBoxPhoneNumber.Text == "" || textBoxEmail.Text == "" || textBoxNationality.Text == "" || textBoxCitizenShip.Text == "" || checkedListBox1.CheckedItems.Count == 0)
            {
                MessageBox.Show("Všechna pole musí být vyplněna a musí být vybrána alespoň jedna položka vzdělání.");
                return;
            }


            //získání dat z textových polí a kontrolních prvků
            string jmeno = Regex.Replace(usernameTextBox.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ]{0,}", "");

            //ověření, zda jméno obsahuje pouze písmena a je alespoň 3 písmena dlouhé
            if (jmeno.Length < 3 || jmeno.Length != usernameTextBox.Text.Length)
            {
                MessageBox.Show("Jméno musí obsahovat pouze písmena a být alespoň 3 písmena dlouhé.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string prijmeni = Regex.Replace(lastnameTextBox.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ]{0,}", "");

            //ověření, zda příjmení obsahuje pouze písmena a je alespoň 3 písmena dlouhé
            if (prijmeni.Length < 3 || prijmeni.Length != lastnameTextBox.Text.Length)
            {
                MessageBox.Show("Příjmení musí obsahovat pouze písmena a být alespoň 3 písmena dlouhé.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string bydliste = Regex.Replace(adressTextBox.Text, @"[^a-zA-Z0-9/ ]{0,}", "");

            //ověření, zda bydliště obsahuje pouze písmena, čísla, lomítka a je alespoň 3 znaky dlouhé
            if (bydliste.Length < 3 || bydliste.Length != adressTextBox.Text.Length)
            {
                MessageBox.Show("Bydliště musí obsahovat pouze písmena, čísla, lomítka a mít alespoň 3 znaky.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            DateTime datum_narozeni = dateTimePicker1.Value;

            if (datum_narozeni > DateTime.Now)
            {
                MessageBox.Show("Datum narození nemůže být v budoucnosti.");
                return;
            }

            string datum_narozeni_str = datum_narozeni.ToString("dd.MM.yyyy"); // převod na řetězec

            Regex datum_regex = new Regex(@"^\d{2}\.\d{2}\.\d{4}$");

            if (!datum_regex.IsMatch(datum_narozeni_str))
            {
                MessageBox.Show("Datum narození musí být ve formátu dd.mm.yyyy.");
                return;
            }




            string telefonni_cislo = Regex.Replace(textBoxPhoneNumber.Text, @"[^0-9 +]{0,}", "");

            // ověření, zda telefonní číslo obsahuje pouze čísla a má alespoň 3 číslice
            if (telefonni_cislo.Length < 3 || telefonni_cislo.Length != textBoxPhoneNumber.Text.Length)
            {
                MessageBox.Show("Telefonní číslo musí obsahovat pouze čísla a být alespoň 3 číslice dlouhé (píše se bez předvolby).");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string email = Regex.Replace(textBoxEmail.Text, @"[^a-zA-Z0-9@._-]+", "");

            // ověření, zda email obsahuje pouze písmena, čísla, @, ., - a _ a obsahuje povinné znaky @ a .
            if (email.Length != textBoxEmail.Text.Length || !email.Contains("@") || !email.Contains("."))
            {
                MessageBox.Show("Email musí obsahovat pouze písmena, čísla, @, ., - a _ a musí obsahovat povinné znaky @ a .");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string narodnost = Regex.Replace(textBoxNationality.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ ]{0,}", "");

            // ověření, zda národnost obsahuje pouze písmena a mezery a má alespoň 5 znaků
            if (narodnost.Length < 5 || narodnost.Length != textBoxNationality.Text.Length)
            {
                MessageBox.Show("Národnost musí obsahovat pouze písmena a mezery a být alespoň 5 znaků dlouhá.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string statni_obcanstvi = Regex.Replace(textBoxCitizenShip.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ ]{0,}", "");

            // ověření, zda státní občanství obsahuje pouze písmena a mezery a má alespoň 5 znaků
            if (statni_obcanstvi.Length < 5 || statni_obcanstvi.Length != textBoxCitizenShip.Text.Length)
            {
                MessageBox.Show("Státní občanství musí obsahovat pouze písmena a mezery a být alespoň 5 znaků dlouhé.");
                return; // ukončí metodu bez uložení dat do databáze
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
            bool result = BLL.InsertUser(jmeno, prijmeni, bydliste, datum_narozeni_str, telefonni_cislo, email, narodnost, statni_obcanstvi, vzdelani);

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

        /// <summary>
        /// Tato metoda otevře odkaz na stránku Úřadu pro ochranu osobních údajů
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelGDPR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.uoou.cz/obecne-narizeni-o-ochrane-osobnich-udaju-gdpr/ds-3938/p1=3938") { UseShellExecute = true });
        }
    }
}