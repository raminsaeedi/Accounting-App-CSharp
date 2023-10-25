using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork();

            Customers customer2 = new Customers
                {
                CustomerID = 2,
                FullName="ADOBE",
                Mobile="Ja",
                CustomerImage="No",
                Address="Inja"
            };

            db.CustomerRepository.InsertCustomer(customer2);
            db.CustomerRepository.Save();
            var list = db.CustomerRepository.GetAllCustomers();

            db.Dispose();
            
        }
    }
}
