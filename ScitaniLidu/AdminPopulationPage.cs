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
        public AdminPopulationPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessLogicLayer BLL = new BusinessLogicLayer();
            List<UserPopulation> users = BLL.GetAllUsers();

            dataGridView1.DataSource = users;
        }
    }
}
