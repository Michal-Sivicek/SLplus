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
    public partial class UserFlatsPage : Form
    {
        /// <summary>
        /// Tato metoda je konstruktor pro třídu UserFlatsPage. Inicializuje komponenty pro uživatelské rozhraní,
        /// nastavuje obsluhu události pro změnu stavu checkboxu checkBoxPodminky a nastavuje tlačítko buttonOdeslat jako neaktivní.
        /// </summary>
        public UserFlatsPage()
        {
            InitializeComponent();
            checkBoxPodminky.CheckedChanged += new EventHandler(checkBoxGDPR_CheckedChanged);
            buttonOdeslat.Enabled = false; //tlačítko odeslat je na začátku neaktivní   
        }


        /// <summary>
        /// Tato metoda slouží k povolení nebo zakázání tlačítka "Odeslat" na stránce s formulářem pro uživatele v závislosti na tom,
        /// zda uživatel označil zaškrtávací políčko pro souhlas s podmínkami (v tomto případě GDPR).
        /// Pokud je políčko označeno, tlačítko "Odeslat" se aktivuje a uživatel může formulář odeslat.
        /// Pokud není políčko označeno, tlačítko "Odeslat" zůstane neaktivní a uživatel nemůže formulář odeslat.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxGDPR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPodminky.Checked == true)
            {
                buttonOdeslat.Enabled = true; //povolí tlačítko odeslat, pokud je CheckBox označen
            }
            else
            {
                buttonOdeslat.Enabled = false; //neaktivní, pokud CheckBox není označen
            }
        }

        /// <summary>
        /// Tato metoda slouží k otevření webové stránky s podmínkami GDPR v prohlížeči.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GDPR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.uoou.cz/obecne-narizeni-o-ochrane-osobnich-udaju-gdpr/ds-3938/p1=3938") { UseShellExecute = true });
        }

        /// <summary>
        /// Tato metoda se spustí po kliknutí na tlačítko "Odeslat" a slouží k ověření a uložení dat uživatele do databáze.
        /// Nejprve se ověří správnost vstupních údajů z textových polí pomocí regulárních výrazů, aby byla zajištěna korektnost dat.
        /// Pokud jsou vstupní údaje správné, uloží se do databáze pomocí metody "InsertFlats" z třídy BusinessLogicLayer.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonOdeslat_Click(object sender, EventArgs e)
        {
            string jmeno = Regex.Replace(textBoxName.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ\s]+", "");

            // ověření, zda jméno obsahuje pouze písmena a má alespoň 7 znaků
            if (jmeno.Length != textBoxName.Text.Length || jmeno.Length < 7)
            {
                MessageBox.Show("Jméno a příjmení musí obsahovat pouze písmena a musí být alespoň 7 znaků dlouhé.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string obec = Regex.Replace(textBoxObec.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ]+", "");

            if (obec.Length != textBoxObec.Text.Length)
            {
                MessageBox.Show("Obec musí obsahovat pouze písmena.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string cislo_domu = Regex.Replace(textBoxCisloDomu.Text, @"[^a-zA-Z0-9]+", "");

            if (cislo_domu.Length != textBoxCisloDomu.Text.Length)
            {
                MessageBox.Show("Číslo domu musí obsahovat pouze čísla a písmena.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string ulice = Regex.Replace(textBoxAdress.Text, @"[^a-zA-Z0-9áčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ., /]+", "");

            if (ulice.Length < 3 || ulice.Length != textBoxAdress.Text.Length)
            {
                MessageBox.Show("Název ulice musí být alespoň tři písmena dlouhý a obsahovat pouze čísla, písmena a některé speciální znaky (háčky, čárky, tečky, lomítka a mezery).");
                return;
            }

            string psc = Regex.Replace(textBoxPSC.Text, @"[^0-9]+", "");

            if (psc.Length < 5)
            {
                MessageBox.Show("PSČ musí obsahovat alespoň 5 čísel.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string obydlenost_bytu = Regex.Replace(textBoxObydlenostBytu.Text, @"[^0-9]+", "");

            if (obydlenost_bytu.Length != textBoxObydlenostBytu.Text.Length)
            {
                MessageBox.Show("Obydlenost bytu musí obsahovat pouze čísla.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string velikost_bytu = Regex.Replace(textBoxVelikostBytu.Text, @"[^0-9]+", "");

            if (velikost_bytu.Length != textBoxVelikostBytu.Text.Length)
            {
                MessageBox.Show("Velikost bytu musí obsahovat pouze čísla.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string podlazi_bytu = Regex.Replace(textBoxPodlaziBytu.Text, @"[^0-9]+", "");

            if (podlazi_bytu.Length != textBoxPodlaziBytu.Text.Length)
            {
                MessageBox.Show("Podlaží bytu musí obsahovat pouze čísla.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string pocet_lidi = Regex.Replace(textBoxPocetLidi.Text, @"[^0-9]+", "");

            if (pocet_lidi.Length != textBoxPocetLidi.Text.Length)
            {
                MessageBox.Show("Počet lidí v bytě musí obsahovat pouze čísla.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            BusinessLogicLayer BLL = new BusinessLogicLayer();
            bool result = BLL.InsertFlats(jmeno, obec, cislo_domu, ulice, psc, obydlenost_bytu, velikost_bytu, podlazi_bytu, pocet_lidi);

            //zpracování výsledku a vypsání informací uživateli
            if (result == true)
            {
                MessageBox.Show("Data byla úspěšně uložena do databáze.");
            }
            else
            {
                MessageBox.Show("Nastala chyba při ukládání dat do databáze.");
            }

            //Vyprázdnění textových polí po uložení dat
            textBoxName.Text = "";
            textBoxObec.Text = "";
            textBoxCisloDomu.Text = "";
            textBoxAdress.Text = "";
            textBoxPSC.Text = "";
            textBoxObydlenostBytu.Text = "";
            textBoxVelikostBytu.Text = "";
            textBoxPodlaziBytu.Text = "";
            textBoxPocetLidi.Text = "";

        }
    }
}
