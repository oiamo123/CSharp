using CustomerData;

namespace CustomerMaintenanceGUI
{
    public partial class frmCustomerMaintenance : Form
    {
        private Customer? selectedCustomer = null; // current customer, may be null
        private List<InvoiceDTO> invoices; // customer invoices
        public frmCustomerMaintenance()
        {
            InitializeComponent();
        }

        private void frmCustomerMaintenance_Load(object sender, EventArgs e)
        {
            // disable buttons that require customer selected
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
        }

        // get customer data
        private void btnGetCustomer_Click(object sender, EventArgs e)
        {
            if (Validator.IsPresent(txtCustomerID) &&
                Validator.IsNonNegativeInt(txtCustomerID))
            {
                int customerID = Convert.ToInt32(txtCustomerID.Text);
                selectedCustomer = CustomerDB.GetCustomer(customerID);
                invoices = CustomerDB.GetCustomerInvoices(customerID);
                if (selectedCustomer != null)
                {
                    DisplayCustomer();
                }
                else // not found
                {
                    MessageBox.Show($"There is no customer with ID {customerID}");
                    ClearControls();
                }

            }
        }

        // reset controls to reflext that there is no selected customer
        private void ClearControls()
        {
            txtCustomerID.Text = "";
            txtName.Text = "";
            txtAddress.Text = "";
            txtCity.Text = "";
            txtState.Text = "";
            txtZipCode.Text = "";
            // disable buttons that require customer selected
            btnModify.Enabled = false;
            btnDelete.Enabled = false;
            // clear invoices grid
            dgvInvoices.DataSource = null;
        }

        // displays selected customer
        private void DisplayCustomer()
        {
            if (selectedCustomer != null)
            {
                txtCustomerID.Text = selectedCustomer.CustomerId.ToString();
                txtName.Text = selectedCustomer.Name;
                txtAddress.Text = selectedCustomer.Address;
                txtCity.Text = selectedCustomer.City;
                txtState.Text = selectedCustomer.State;
                txtZipCode.Text = selectedCustomer.ZipCode;
                // enable buttons that require customer selected
                btnModify.Enabled = true;
                btnDelete.Enabled = true;
                // display related invoices
                dgvInvoices.DataSource = invoices;
                dgvInvoices.Columns[3].DefaultCellStyle.Format = "c";
            }
        }

        // add a new customer
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAddModifyCustomer secondForm = new frmAddModifyCustomer();
            secondForm.isAdd = true;
            secondForm.customer = null;
            DialogResult result = secondForm.ShowDialog(); // displays modal form
            if (result == DialogResult.OK)
            {
                selectedCustomer = secondForm.customer; // get customer data from the second form
                CustomerDB.AddCustomer(selectedCustomer!); // we know it is not null
                DisplayCustomer();
            }
        }

        // modify selected customer
        private void btnModify_Click(object sender, EventArgs e)
        {
            frmAddModifyCustomer secondForm = new frmAddModifyCustomer();
            secondForm.isAdd = false;
            secondForm.customer = selectedCustomer; // we know selectedCustomer is not null
            DialogResult result = secondForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                if (secondForm.customer != null)
                {
                    CustomerDB.ModifyCustomer(selectedCustomer!.CustomerId, secondForm.customer);
                    DisplayCustomer();
                }
            }
        }

        // delete selected customer
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedCustomer != null)
            {
                // get confirmation by the user
                DialogResult answer = MessageBox.Show($"Do you want to delete {selectedCustomer.Name}?",
                    "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (answer == DialogResult.Yes) // user confirmed
                {
                    CustomerDB.DeleteCustomer(selectedCustomer.CustomerId);
                    MessageBox.Show("Customer deleted");
                    ClearControls();
                }
            }
        }

        // terminate app
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
