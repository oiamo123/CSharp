using CustomerData;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerMaintenanceGUI
{
    public partial class frmAddModifyCustomer : Form
    {
        public bool isAdd; // main form sets to true when Add  and false when Modify
        public Customer? customer; // for modify, themain form will set it to the selected customer
        public frmAddModifyCustomer()
        {
            InitializeComponent();
        }

        private void frmAddModifyCustomer_Load(object sender, EventArgs e)
        {
            LoadStates();
            if (isAdd)
            {
                this.Text = "Add Customer";
            }
            else // Modify
            {
                this.Text = "ModifyCustomer";
                DisplayCustomer(); // start with current data
            }
        }

        private void DisplayCustomer()
        {
            if (customer != null)
            {
                txtName.Text = customer.Name;
                txtAddress.Text = customer.Address; 
                txtCity.Text = customer.City;
                cboState.SelectedValue = customer.State;
                txtZipCode.Text = customer.ZipCode;
            }

        }

        private void LoadStates()
        {
            List<State> states = StateDB.GetStates();
            cboState.DataSource = states;
            cboState.DisplayMember = "StateName"; // names displayed in the list
            cboState.ValueMember = "StateCode"; // the code is selected
        }

        // user accepted the new data
        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtName) &&
                Validator.IsPresent(txtAddress) &&
                Validator.IsPresent(txtCity) &&
                Validator.IsSelected(cboState) &&
                Validator.IsPresent(txtZipCode)
                )
            {
                if(isAdd) // Add operation
                {
                    customer = new Customer();
                    FillCustomer(customer);
                }
                else // Modify operation
                {
                    FillCustomer(customer!); // customer should not be null here
                }
                this.DialogResult = DialogResult.OK;
            }
        }

        private void FillCustomer(Customer customer)
        {
            customer.Name = txtName.Text;
            customer.Address = txtAddress.Text;
            customer.City = txtCity.Text;
            customer.State = cboState.SelectedValue!.ToString()!; // do not worry about null
            customer.ZipCode = txtZipCode.Text;
        }
    }
}
