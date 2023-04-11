using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
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
    }
}
