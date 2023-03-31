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
    public partial class Finances : Form
    {
        public Finances()
        {
            InitializeComponent();
        }

        private void Finances_Load(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void IncomeTab_Click(object sender, EventArgs e)
        {

        }

        private void ExpensesTab_Click(object sender, EventArgs e)
        {

        }

        private void SalesTab_Click(object sender, EventArgs e)
        {

        }

        private void BalanceTab_Click(object sender, EventArgs e)
        {

        }

        private void UpcomingTab_Click(object sender, EventArgs e)
        {

        }

        private void DashboardTab_Click(object sender, EventArgs e)
        {
            Dashboard Ob = new Dashboard();
            Ob.Show();
            this.Hide();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
