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
        public UserFlatsPage()
        {
            InitializeComponent();
            checkBoxPodminky.CheckedChanged += new EventHandler(checkBoxGDPR_CheckedChanged);
            buttonOdeslat.Enabled = false; //tlačítko odeslat je na začátku neaktivní   
        }

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

        private void GDPR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.uoou.cz/obecne-narizeni-o-ochrane-osobnich-udaju-gdpr/ds-3938/p1=3938") { UseShellExecute = true });
        }

        private void buttonOdeslat_Click(object sender, EventArgs e)
        {
            string jmeno = Regex.Replace(textBoxName.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ]+", "");

            //ověření, zda jméno obsahuje pouze písmena
            if (jmeno.Length != textBoxName.Text.Length)
            {
                MessageBox.Show("Jméno musí obsahovat pouze písmena.");
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

            string ulice = Regex.Replace(textBoxAdress.Text, @"[^a-zA-Z0-9]+", "");

            if (ulice.Length != textBoxAdress.Text.Length)
            {
                MessageBox.Show("Název ulice musí obsahovat pouze čísla a písmena.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string psc = Regex.Replace(textBoxPSC.Text, @"[^0-9]+", "");

            if (psc.Length != textBoxPSC.Text.Length)
            {
                MessageBox.Show("PSČ musí obsahovat pouze čísla.");
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



        }
    }
}
