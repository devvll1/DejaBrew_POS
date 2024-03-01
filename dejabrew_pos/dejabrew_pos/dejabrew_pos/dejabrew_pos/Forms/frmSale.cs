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
    public partial class frmSale : Form
    {
        public frmSale()
        {
            InitializeComponent();
        }

        Functions.SalePrint print = new Functions.SalePrint();

        private void frmSale_Load(object sender, EventArgs e)
        {
            print.printData(this.rprtSaleOrder);
            this.rprtSaleOrder.RefreshReport();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            Forms.frmDashboard frmDashboard = new Forms.frmDashboard();
            frmDashboard.Show();
            this.Hide();
        }
    }
}
