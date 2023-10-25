using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ValidationComponents;

namespace Accounting.App
{
    public partial class frmAddOrEditCustomers : Form
    {
        public int customerId = 0;
        //UnitOfWork db = new UnitOfWork();
        public frmAddOrEditCustomers()
        {
            InitializeComponent();
        }

        private void frmAddOrEditCustomers_Load(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (customerId != 0)
                {
                    this.Text = "Edit person";
                    btnSave.Text = "Edit";

                    var customer = db.CustomerRepository.GetCustomerById(customerId);
                    txtName.Text = customer.FullName;
                    txtAddress.Text = customer.Address;
                    txtEmail.Text = customer.Email;
                    txtMobile.Text = customer.Mobile;
                    pcCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImage;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnSelectPhoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pcCustomer.ImageLocation = openFile.FileName;
            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                if (BaseValidator.IsFormValid(this.components))
                {
                    string imageName = Guid.NewGuid().ToString() + Path.GetExtension(pcCustomer.ImageLocation);
                    string path = Application.StartupPath + "/Images/";
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                    pcCustomer.Image.Save(path + imageName);
                    Customers customers = new Customers()
                    {
                        FullName = txtName.Text,
                        Address = txtAddress.Text,
                        Email = txtEmail.Text,
                        Mobile = txtMobile.Text,
                        CustomerImage = imageName
                    };

                    if (Convert.ToInt32(customerId) == 0)
                    {
                        db.CustomerRepository.InsertCustomer(customers);
                    }
                    else
                    {
                        customers.CustomerID = customerId;
                        db.CustomerRepository.UpdateCustomer(customers);
                    }
                    db.Save();

                    DialogResult = DialogResult.OK;
                }
            }

        }
    }
}
