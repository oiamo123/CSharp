using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerData
{
    /// <summary>
    /// repository of static data access methods for working with Customers table 
    /// in MMABooks database
    /// </summary>
    public static class CustomerDB
    {
        /// <summary>
        /// retrieve customer with given id
        /// </summary>
        /// <param name="customerId">id for customer to retrieve</param>
        /// <returns>requested customer or null if not found</returns>
        public static Customer? GetCustomer(int customerId)
        {
            Customer? customer = null;
            using(MMABooksContext db = new MMABooksContext())
            {
                customer = db.Customers.Find(customerId); // returns null when not found
            }
            return customer;
        }

        public static List<InvoiceDTO> GetCustomerInvoices(int customerId)
        {
            List<InvoiceDTO> invoices = new List<InvoiceDTO>(); // empty list
            using(MMABooksContext db = new MMABooksContext())
            {
                Customer? customer = db.Customers.Find(customerId);
                if(customer != null)
                {
                    invoices = customer.Invoices.Select(
                        i => new InvoiceDTO { 
                            InvoiceId = i.InvoiceId,
                            CustomerId = i.CustomerId,
                            InvoiceDate = i.InvoiceDate,
                            InvoiceTotal = i.InvoiceTotal
                        }).ToList();
                }                
            }
            return invoices;
        }

        /// <summary>
        /// adds a new record to the Customers table
        /// </summary>
        /// <param name="customer">customer data to add</param>
        public static void AddCustomer(Customer customer)
        {
            using(MMABooksContext db = new MMABooksContext())
            {
                if (customer != null)
                {
                    db.Customers.Add(customer); // adds to the collection customers in the app
                    db.SaveChanges(); // save change to the database
                }
            }
        }

        /// <summary>
        /// modifies existing customer record with  new data
        /// </summary>
        /// <param name="customerId">id of the custimer to modify</param>
        /// <param name="newCustomerData">new data</param>
        public static void ModifyCustomer(int customerId, Customer newCustomerData)
        {
            using (MMABooksContext db = new MMABooksContext())
            {
                Customer? cust = db.Customers.Find(customerId);
                if (cust != null) // modify existing customer object in the app
                {
                    cust.Name = newCustomerData.Name;
                    cust.Address = newCustomerData.Address;
                    cust.City = newCustomerData.City;
                    cust.State = newCustomerData.State;
                    cust.ZipCode = newCustomerData.ZipCode;
                }
                db.SaveChanges(); // save changes to the database
            }
        }

        /// <summary>
        /// deletes existing customer
        /// </summary>
        /// <param name="customerId"> id of the customer to delete</param>
        public static void DeleteCustomer(int customerId)
        {
            using(MMABooksContext db = new MMABooksContext())
            {
                Customer? cust = db.Customers.Find(customerId);
                if (cust != null) // if found
                {
                    db.Customers.Remove(cust);
                    db.SaveChanges();
                }
            }
        }

    }
}
