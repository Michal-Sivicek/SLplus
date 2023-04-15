using ScitaniLidu;
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
    public partial class UserHousesPage : Form
    {
        public UserHousesPage()
        {
            InitializeComponent();
            this.AcceptButton = button1; //nastavení klávesové zkratky na enter
            checkBoxGDPR.CheckedChanged += new EventHandler(checkBoxGDPR_CheckedChanged);
            button1.Enabled = false; //tlačítko odeslat je na začátku neaktivní
        }

        private void checkBoxGDPR_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxGDPR.Checked == true)
            {
                button1.Enabled = true; //povolí tlačítko odeslat, pokud je CheckBox označen
            }
            else
            {
                button1.Enabled = false; //neaktivní, pokud CheckBox není označen
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kontrola, zda jsou všechny textové pole vyplněny
            if (textBox1.Text == "" || textBoxObec.Text == "" || textBoxNumberHouse.Text == "" || textBoxAdress.Text == "" || textBoxPSC.Text == "" || textBoxObydlenostDomu.Text == "" || textBoxVystavbaRekonstrukce.Text == "" || textBoxMaterialZdi.Text == "" || textBoxPocetPodlazi.Text == "")
            {
                MessageBox.Show("Všechna pole musí být vyplněna.");
                return;
            }

            string jmeno_prijmeni = Regex.Replace(textBox1.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ]+", "");

            if (jmeno_prijmeni.Length != textBox1.Text.Length)
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

            string cislo_domu = Regex.Replace(textBoxNumberHouse.Text, @"[^a-zA-Z0-9]+", "");

            if (cislo_domu.Length != textBoxNumberHouse.Text.Length)
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

            string obydlenost_domu = Regex.Replace(textBoxObydlenostDomu.Text, @"[^0-9]+", "");

            if (obydlenost_domu.Length != textBoxObydlenostDomu.Text.Length)
            {
                MessageBox.Show("Obydlenost domu musí obsahovat pouze čísla.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string rok_vystavby = Regex.Replace(textBoxVystavbaRekonstrukce.Text, @"[^0-9]+", "");

            if (rok_vystavby.Length != textBoxVystavbaRekonstrukce.Text.Length)
            {
                MessageBox.Show("Rok výstavby musí obsahovat pouze čísla.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string material_zdi = Regex.Replace(textBoxMaterialZdi.Text, @"[^a-zA-ZáčďéěíňóřšťúůýžÁČĎÉĚÍŇÓŘŠŤÚŮÝŽ]+", "");

            if (material_zdi.Length != textBoxMaterialZdi.Text.Length)
            {
                MessageBox.Show("Material zdi musí obsahovat pouze písmena.");
                return; // ukončí metodu bez uložení dat do databáze
            }

            string pocet_podlazi = Regex.Replace(textBoxPocetPodlazi.Text, @"[^0-9]+", "");

            if (pocet_podlazi.Length != textBoxPocetPodlazi.Text.Length)
            {
                MessageBox.Show("Pocet podlazi musí obsahovat pouze cisla.");
                return; // ukončí metodu bez uložení dat do databáze
            }


            BusinessLogicLayer BLL = new BusinessLogicLayer();
            bool result = BLL.InsertHouse(jmeno_prijmeni, obec, cislo_domu, ulice, psc, obydlenost_domu, rok_vystavby, material_zdi, pocet_podlazi);

            //zpracování výsledku a vypsání informací uživateli
            if (result == true)
            {
                MessageBox.Show("Data byla úspěšně uložena do databáze.");
            }
            else
            {
                MessageBox.Show("Nastala chyba při ukládání dat do databáze.");
            }

            // Odstranění dat z textových polí po úspěšném uložení do databáze
            textBox1.Text = "";
            textBoxObec.Text = "";
            textBoxNumberHouse.Text = "";
            textBoxAdress.Text = "";
            textBoxPSC.Text = "";
            textBoxObydlenostDomu.Text = "";
            textBoxVystavbaRekonstrukce.Text = "";
            textBoxMaterialZdi.Text = "";
            textBoxPocetPodlazi.Text = "";
        }

        private void linkLabelGDPR_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://www.uoou.cz/obecne-narizeni-o-ochrane-osobnich-udaju-gdpr/ds-3938/p1=3938") { UseShellExecute = true });
        }
    }
}
