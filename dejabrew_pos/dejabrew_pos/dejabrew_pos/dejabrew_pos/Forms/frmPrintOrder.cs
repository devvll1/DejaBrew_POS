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
    public partial class frmPrintOrder : Form
    {
        public frmPrintOrder()
        {
            InitializeComponent();
        }

        private void frmPrintOrder_Load(object sender, EventArgs e)
        {

            this.rprtReceipt.RefreshReport();
        }
    }
}
