using DocumentFormat.OpenXml.Wordprocessing;
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
    public partial class AdminFlatsPage : Form
    {
        /// <summary>
        /// V této metodě je volána metoda InitializeComponent(), která inicializuje všechny komponenty formuláře, včetně grafických prvků a událostí.  
        /// </summary>
        public AdminFlatsPage()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Tato metoda slouží k získání seznamu uživatelů a jejich bytů z databáze a následnému zobrazení těchto dat v datové mřížce dataGridView1.
        ///V metodě se vytváří instance třídy BusinessLogicLayer, která obsahuje logiku pro zpracování dat z databáze.Dále se pomocí metody GetAllUserHouses()
        ///získají všechny uživatelské byty z databáze a uloží se do seznamu users.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonVypisBytu_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            List<UserHouse> users = BLL.GetAllUserHouses();

            dataGridView1.DataSource = users;
        }
    }
}
