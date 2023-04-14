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
        public AdminFlatsPage()
        {
            InitializeComponent();
        }

        private void buttonVypisBytu_Click(object sender, EventArgs e)
        {

            BusinessLogicLayer BLL = new BusinessLogicLayer();
            List<UserHouse> users = BLL.GetAllUserHouses();

            dataGridView1.DataSource = users;
        }
    }
}
