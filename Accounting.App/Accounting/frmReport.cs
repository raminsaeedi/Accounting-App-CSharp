using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.ViewModels.Customers;
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
    public partial class frmReport : Form
    {
        public int TypeID = 0;
        public frmReport()
        {
            InitializeComponent();
        }

        private void frmReport_Load(object sender, EventArgs e)
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                List<ListCustomerViewModel> list = new List<ListCustomerViewModel>();
                list.Add(new ListCustomerViewModel()
                {
                    CustomerID=0,
                    FullName="select a Person"
                });
                list.AddRange(db.CustomerRepository.GetNameCustomers());
                cbCustomer.DataSource = list;
                cbCustomer.DisplayMember = "FullName";
                cbCustomer.ValueMember = "CustomerID";
            }
            if(TypeID == 1)
            {
                this.Text = "Report Recieves";
            }
            else
            {
                this.Text = "Report Pays";
            }
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }
        void Filter()
        {
            using(UnitOfWork db = new UnitOfWork())
            {
                List<DataLayer.Accounting> result = new List<DataLayer.Accounting>();
                DateTime? startDate;
                DateTime? endDate;
                if((int)cbCustomer.SelectedValue != 0)
                {
                    int customerId = int.Parse(cbCustomer.SelectedValue.ToString());
                    result.AddRange(db.AccountingRepository.Get(a=>a.TypeID== TypeID &&  a.CustomerID==customerId));
                }
                else
                {
                    result.AddRange(db.AccountingRepository.Get(a => a.TypeID== TypeID));
                }
                if (txtFromDate.Text != "  .  .")
                {
                    startDate = Convert.ToDateTime(txtFromDate.Text);
                    result = result.Where(r => r.DateTitle >= startDate.Value).ToList();
                }
                if(txtToDate.Text != "  .  .")
                {
                    endDate = Convert.ToDateTime(txtToDate.Text);
                    result= result.Where(r => r.DateTitle <= endDate.Value).ToList();
                }
                
                dgReport.Rows.Clear();
                foreach(var transaction in result)
                {
                    string customerName = db.CustomerRepository.GetCustomerNameById(transaction.CustomerID);
                    dgReport.Rows.Add(
                        transaction.ID, 
                        customerName, 
                        transaction.Amount, 
                        transaction.DateTitle,
                        transaction.Description);
                }
            }
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                if(MessageBox.Show("Are you sure to delete this transaction?!", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    using(UnitOfWork db=new UnitOfWork())
                    {
                        db.AccountingRepository.Delete(id);
                        db.Save();
                        Filter();
                    }
                }
            }
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dgReport.CurrentRow != null)
            {
                int id = int.Parse(dgReport.CurrentRow.Cells[0].Value.ToString());
                frmNewTransaction frmNew = new frmNewTransaction();
                frmNew.AccountID = id;
                if(frmNew.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }
    }
}
