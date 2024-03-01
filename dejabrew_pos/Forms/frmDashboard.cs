using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dejabrew_pos.Forms
{
    public partial class frmDashboard : Form
    {
        public frmDashboard()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void btnSale_Click(object sender, EventArgs e)
        {
            Forms.frmSale frmSale = new Forms.frmSale();
            frmSale.Show();
            this.Hide();


        }

        private void btnInventory_Click(object sender, EventArgs e)
        {
            Forms.frmInventory frmInventory = new Forms.frmInventory();
            frmInventory.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            Forms.frmOrder frmOrder = new Forms.frmOrder();
            frmOrder.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void frmDashboard_Load(object sender, EventArgs e)
        {

        }
    }
}
