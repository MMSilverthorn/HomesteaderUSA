using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomesteaderUSA
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void TopPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BottomPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void DashboardLabel_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Splid principle Seperation of functions. Each small inerface has one specific function.. for example logging all breeding
        /// Interface segregation. Each section has its own small simple interface. Breeding, Health, Milk Production
        /// Further seperation was done on the dashboard to get to similar interfaces..ie anything related to the animals
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void label3_Click(object sender, EventArgs e)
        {
            Animals Ob = new Animals();
            Ob.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Plants Ob = new Plants();
            Ob.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {
            Finances Ob = new Finances();
            Ob.Show();
            this.Hide();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Users Ob = new Users();
            Ob.Show();
            this.Hide();
        }

        private void Users_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            Journal Ob = new Journal();
            Ob.Show();
            this.Hide();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
