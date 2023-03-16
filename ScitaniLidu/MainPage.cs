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
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
            // Nastavení velikosti písma Labelu
            MainText.Font = new Font(MainText.Font.FontFamily, 12);
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }
    }
}
