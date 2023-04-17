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
    public partial class AdminPopulationPage : Form
    {
        /// <summary>
        /// Metoda volá privátní metodu InitializeComponent(), která inicializuje všechny komponenty (tlačítka, textová pole, tabulky atd.)
        /// na formuláři na jejich výchozí hodnoty a nastavení.
        /// </summary>
        public AdminPopulationPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tato metoda slouží k získání seznamu uživatelů a jejich obyvatel z databáze a následnému zobrazení těchto dat v datové mřížce dataGridView1.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            List<UserPopulation> users = BLL.GetAllUsers();

            dataGridView1.DataSource = users;
        }
    }
}
