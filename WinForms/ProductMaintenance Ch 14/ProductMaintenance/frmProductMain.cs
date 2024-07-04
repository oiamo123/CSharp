namespace ProductMaintenance
{
    public partial class frmProductMain : Form
    {
        public frmProductMain()
        {
            InitializeComponent();
        }

        private ProductList products = new();

        private void frmProductMain_Load(object sender, EventArgs e)
        {
            products.Fill();
            FillProductListBox();
        }

        private void FillProductListBox()
        {
            lstProducts.Items.Clear();
            foreach (Product p in products)
                lstProducts.Items.Add(p.GetDisplayText("\t"));
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmNewProduct newProductForm = new();
            Product product = newProductForm.GetNewProduct();
            if (product != null)
            {
                products.Add(product);
                products.Save();
                FillProductListBox();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int i = lstProducts.SelectedIndex;
            if (i != -1)
            {
                Product product = products[i];

                string message = $"Are you sure you want to delete {product.Description}?";

                DialogResult button =
                    MessageBox.Show(message, "Confirm Delete",
                    MessageBoxButtons.YesNo);

                if (button == DialogResult.Yes)
                {
                    products.Remove(product);
                    products.Save();
                    FillProductListBox();
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}     