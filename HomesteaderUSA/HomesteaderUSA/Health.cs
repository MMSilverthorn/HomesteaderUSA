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
    public partial class Health : Form
    {
        public Health()
        {
            InitializeComponent();
        }

        private void Health_Load(object sender, EventArgs e)
        {

        }

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void panel9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void AnimalTabLabel_Click(object sender, EventArgs e)
        {
            Animals Ob = new Animals();
            Ob.Show();
            this.Hide();
        }

        private void MilkTab_Click(object sender, EventArgs e)
        {
            Milk Ob = new Milk();
            Ob.Show();
            this.Hide();
        }

        private void ProductLogTab_Click(object sender, EventArgs e)
        {
            Product Ob = new Product();
            Ob.Show();
            this.Hide();
        }

        private void HealthTab_Click(object sender, EventArgs e)
        {

        }

        private void BreedTabLabel_Click(object sender, EventArgs e)
        {
            Breed Ob = new Breed();
            Ob.Show();
            this.Hide();
        }

        private void DashboardTab_Click(object sender, EventArgs e)
        {
            Dashboard Ob = new Dashboard();
            Ob.Show();
            this.Hide();
        }

        private void CloseProgram_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HealthDGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }
    }
}
