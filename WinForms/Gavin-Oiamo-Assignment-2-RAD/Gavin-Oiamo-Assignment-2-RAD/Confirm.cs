using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomerData;


namespace Gavin_Oiamo_Assignment_2_RAD
{
    public partial class Confirm : Form
    {
        // variables
        List<Customer> customers { get; set; }
        ListBox lstCustomers { get; set; }

        // Confirm constructor
        public Confirm(ListBox lstCustomers, List <Customer> customers)
        {
            InitializeComponent();
            this.customers = customers;
            this.lstCustomers = lstCustomers;
        }

        // Closes modal on exit button click event
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // calls handle confirm method in statistics on continue button click event and closes confirmation box
        private void btnContinue_Click(object sender, EventArgs e)
        {
            Statistics.handleConfirm(customers, lstCustomers);
            this.Close();
        }
    }
}
