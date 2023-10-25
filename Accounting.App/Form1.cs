using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accounting.App
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            FrmCustomers frmCustomers = new FrmCustomers();
            frmCustomers.ShowDialog();
        }


        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            frmNewTransaction frmNewTransaction = new frmNewTransaction();
            frmNewTransaction.ShowDialog();
        }

        private void btnReportPay_Click(object sender, EventArgs e)
        {
            frmReport frmReportPay = new frmReport();
            frmReportPay.TypeID = 2;
            frmReportPay.ShowDialog();
        }

        private void btnReportRecieve_Click(object sender, EventArgs e)
        {
            frmReport frmReportRecieve = new frmReport();
            frmReportRecieve.TypeID = 1;
            frmReportRecieve.ShowDialog();

        }
    }
}
