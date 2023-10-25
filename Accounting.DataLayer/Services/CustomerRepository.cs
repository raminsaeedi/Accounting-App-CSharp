using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Accounting.ViewModels.Customers;

namespace Accounting.DataLayer.Services
{
    public class CustomerRepository : ICustomerRepository
    {
        private Accounting_DBEntities db;
        public CustomerRepository(Accounting_DBEntities context)
        {
            db = context;
        }
        public bool DeleteCustomer(Customers customer)
        {
            try
            {
                db.Entry(customer).State = EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool DeleteCustomer(int customerId)
        {
            try
            {
                var customer = GetCustomerById(customerId);
                DeleteCustomer(customer);
                return true;
            }
            catch 
            {
                return false;
            }
            
        }

        public List<Customers> GetAllCustomers()
        {
            return db.Customers.ToList();
        }

        public Customers GetCustomerById(int customerId)
        {
            return db.Customers.Find(customerId);
        }

        public bool InsertCustomer(Customers customer)
        {
            try
            {

                db.Customers.Add(customer);
                //db.Entry(customer).State = EntityState.Added;
                //db.Entry(customer).Property(p => p.CustomerID).IsModified = false;
                return true;
                
            }
            catch
            {
                return false;
            }
        }



        public bool UpdateCustomer(Customers customer)
        {
            try
            {
                var existingCustomer = db.Customers.Find(customer.CustomerID);
                if (existingCustomer != null)
                {
                    db.Entry(existingCustomer).CurrentValues.SetValues(customer);
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }

        public IEnumerable<Customers> GetCustomersByFilter(string parameter)
        {
            return db.Customers.Where(
                c => c.FullName.Contains(parameter)||c.Email.Contains(parameter)||c.Mobile.Contains(parameter)).ToList();
        }

        public List<ListCustomerViewModel> GetNameCustomers(string filter)
        {
            if (filter == "")
            {
                return db.Customers.OrderBy(c => c.FullName)
                    .Select(c => new ListCustomerViewModel()
                {
                    CustomerID = c.CustomerID,
                    FullName = c.FullName,
                }).ToList();
            }

            return db.Customers.Where(c => c.FullName.Contains(filter)).OrderBy(c => c.FullName)
                .Select(c => new ListCustomerViewModel()
            {
                CustomerID = c.CustomerID,
                FullName = c.FullName,
            }).ToList();
        }

        int ICustomerRepository.GetCustomerIdByName(string name)
        {
            return db.Customers.FirstOrDefault(c => c.FullName == name).CustomerID;
        }

        public string GetCustomerNameById(int customerId)
        {
            return db.Customers.Find(customerId).FullName;
        }
    }
}
