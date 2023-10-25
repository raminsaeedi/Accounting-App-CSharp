using Accounting.DataLayer;
using Accounting.DataLayer.Context;
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
    public partial class frmNewTransaction : Form
    {
        UnitOfWork db;
        public int AccountID =0;
        public frmNewTransaction()
        {
            InitializeComponent();
        }

        private void frmNewTransaction_Load(object sender, EventArgs e)
        {
            db = new UnitOfWork();
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.CustomerRepository.GetNameCustomers();
            if(AccountID != 0)
            {
                var account = db.AccountingRepository.GetById(AccountID);
                txtAmount.Text = account.Amount.ToString();
                txtDescription.Text = account.Description.ToString();
                txtName.Text = db.CustomerRepository.GetCustomerNameById(account.CustomerID);
                if(account.TypeID == 1)
                {
                    rbRecieve.Checked = true;
                }
                else
                {
                    rbPay.Checked = true;
                }
                this.Text = "Edit";
                btnSave.Text = "Edit";
                db.Dispose();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            dgvCustomers.AutoGenerateColumns = false;
            dgvCustomers.DataSource = db.CustomerRepository.GetNameCustomers(txtFilter.Text);
        }

        private void dgvCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtName.Text = dgvCustomers.CurrentRow.Cells[0].Value.ToString();
        }

        private void textEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            
            if(rbPay.Checked || rbRecieve.Checked)
            {
                db = new UnitOfWork();
                DataLayer.Accounting accounting = new DataLayer.Accounting() 
                { 
                    CustomerID = db.CustomerRepository.GetCustomerIdByName(txtName.Text),
                    Amount = int.Parse(txtAmount.Value.ToString()),
                    TypeID = (rbPay.Checked ? 2 : 1),
                    DateTitle = DateTime.Now,
                    Description = txtDescription.Text,
                };
                if (AccountID ==0)
                {
                    db.AccountingRepository.Insert(accounting);

                }
                else
                {
                    accounting.ID = AccountID;
                    db.AccountingRepository.Update(accounting);
                }
                db.Save();
                db.Dispose();
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("please choose the tranaction!");
            }
        }
    }
}
