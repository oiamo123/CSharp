using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerData;
using Gavin_Oiamo_Assignment_2_RAD;
using Transaction_Class;

namespace Gavin_Oiamo_Assignment_2_RAD
{
    public partial class Statistics : Form
    {
        // customers list
        List<Customer> customers { get; set; }

        // constructor function that takes customers list
        public Statistics(List<Customer> customers)
        {
            InitializeComponent();
            this.customers = customers;
        }

        // close statistics when exit is clicked
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // when statistics form loads, list all customers in listbox
        private void Statistics_Load(object sender, EventArgs e)
        {
            foreach (Customer customer in customers)
            {
                lstCustomers.Items.Add($"First name: {customer.FirstName}, Last name: {customer.LastName}, AccountNo: {customer.accountNumber}, kWh Used: {customer.kwhUsed}, Bill total: {customer.elecBill:c}");
            }
        }

        // when >>> button is clicked, show customers transactions
        private void btnViewMore_Click(object sender, EventArgs e)
        {
            try
            {
                // if a user isn't selected, show a warning message
                if (lstCustomers.SelectedItem == null) throw new Exception("You must select a user");

                // hide remove buttons when >>> is clicked
                btnRemove.Hide();

                // get selected item, split it into an array
                string[] custString = lstCustomers.SelectedItem.ToString().Split(" ");

                // find customer in customers List using firstname and lastname
                Customer? cust = customers.Find(cust => cust.FirstName == custString[2].Replace(',', ' ').Trim() && cust.LastName == custString[5].Replace(',', ' ').Trim());

                // clear all items in list box
                lstCustomers.Items.Clear();

                // add each transaction to listbox
                foreach (Transaction transaction in cust.transactions)
                {
                    lstCustomers.Items.Add($"Transaction date: {DateTime.Parse(transaction.transactionDate.ToString())}, Transaction kWh: {transaction.transactionKwh}, Transaction cost: {transaction.transactionCost:c}");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        // <<< button is clicked, go back to all customers
        private void btnViewLess_Click(object sender, EventArgs e)
        {
            // clear all items in list box
            lstCustomers.Items.Clear();

            // show remove
            btnRemove.Show();

            // list all customers
            foreach (Customer customer in customers)
            {
                lstCustomers.Items.Add($"First name: {customer.FirstName}, Last name: {customer.LastName}, AccountNo: {customer.accountNumber}, kWh Used: {customer.kwhUsed}, Bill total: {customer.elecBill:c}");
            }
        }

        // remove button is clicked, check to see if an item is selected and show confirmation box
        private void btnRemove_Click(object sender, EventArgs e)
        {   
            if (lstCustomers.SelectedItem == null) MessageBox.Show("You must select a customer.");

            // create new confirm form
            Form confirm = new Confirm(lstCustomers, customers);
            confirm.Show();
        }

        // handles confirm button event on confirm form. takes customers and lstcustomers as arguments
        static public void handleConfirm(List<Customer> customers, ListBox lstCustomers)
        {
            // get selected item and turn it into an array
            string[] custString = lstCustomers.SelectedItem.ToString().Split(" ");

            // find customer in customers list
            Customer? cust = customers.Find(cust => cust.FirstName == custString[2].Replace(',', ' ').Trim() && cust.LastName == custString[5].Replace(',', ' ').Trim());

            // delete customer from customers list
            customers.Remove(cust);

            // clear items in list box and reload
            lstCustomers.Items.Clear();
            foreach (Customer customer in customers)
            {
                lstCustomers.Items.Add($"First name: {customer.FirstName}, Last name: {customer.LastName}, AccountNo: {customer.accountNumber}, kWh Used: {customer.kwhUsed}, Bill total: {customer.elecBill:c}");
            }
            
        }
    }
}
