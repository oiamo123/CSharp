/*
 * AUTHOR: GAVIN OIAMO
 * DATE: 2024/07/03
 * PURPOSE: CLASS FOR MODIFY / ADD FORM 
 */

using ProductMaintenance.Data;
using ProductMaintenance.Models;
using System.Data;
using System.Text.RegularExpressions;

namespace ProductMaintenance
{
    public partial class Modify : Form
    {
        TechSupportContext context = new TechSupportContext(); // references db
        Validation validator = new Validation(); // Creates instance of validation

        string prodId { get; set; } // Product Code passed in from List box selected item
        string type { get; set; } // Type is either "Add" or "Modify"
        Form1 formMain { get; set; } // References Form1 / Product main form

        /// <summary>
        /// Creates either a Modify or Add form
        /// </summary>
        /// <param name="type">Type ie "Add" or "Modify"</param>
        /// <param name="formMain">Reference to main form</param>
        /// <param name="prodId">Product Code</param>
        public Modify(string type, Form1 formMain, string prodId = "")
        {
            InitializeComponent();
            this.type = type;
            this.prodId = prodId;
            this.formMain = formMain;
            this.Text = $"{type} Product";
        }

        /// <summary>
        /// Closes Add/Modify form on click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Updates textboxes with correct data if type is "modify" on form load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Modify_Load(object sender, EventArgs e)
        {
            if (type == "Modify")
            {
                // db query
                var products = context.Products.Select(p => new
                {
                    ProductCode = p.ProductCode.TrimEnd(),
                    p.Name,
                    p.Version,
                    ReleaseDate = p.ReleaseDate.ToString("dd/MM/yyyy", System.Globalization.CultureInfo.InvariantCulture)
                }).Where(p => p.ProductCode.Equals(prodId)).ToList();

                // get release date
                int day = int.Parse(products[0].ReleaseDate.Substring(0, 2));
                int month = int.Parse(products[0].ReleaseDate.Substring(3, 2));
                int year = int.Parse(products[0].ReleaseDate.Substring(6, 4));

                // update textboxes
                txtProdCode.Text = products[0].ProductCode;
                txtName.Text = formatName(products[0].Name);
                txtVersion.Text = products[0].Version.ToString();
                dtpProdDate.Value = new DateTime(year, month, day);

                // product code is reead only
                txtProdCode.ReadOnly = true;
            }
            else
            {
                clearTxtBoxes();
            }
        }

        /// <summary>
        /// Clear textboxes
        /// </summary>
        private void clearTxtBoxes()
        {
            txtProdCode.Text = "";
            txtName.Text = "";
            txtVersion.Text = "";
            dtpProdDate.Value = DateTime.Now;
        }

        /// <summary>
        /// Adds or modifies products on OK button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                // formats product name ie turns "Test Verion 1.0" into "Test Version"
                string nameFormatted = formatName(txtName.Text);

                //Turns Product code ie "test" and version ie "1" into "TEST10" for Product code
                string prodName = $"{txtProdCode.Text.ToUpper()}" +
                    $"{Decimal.Parse(txtVersion.Text).ToString("0.0").Replace(".", "")}";

                // if form is type "add" and data is valid, check to see if product code is unique, 
                // add product, update listbox and clear textboxes
                if (type == "Add" && validator.checkIsWord(txtProdCode.Text, "Product Code")
                    && validator.checkIsSentence(txtName.Text, "Name")
                    && validator.checkIsDecimal(txtVersion.Text, "Version"))
                {
                    if (context.Products.Find(prodName) != null)
                        throw new Exception("This product already exists");

                    var product = new Product() // declares new product
                    {
                        ProductCode = prodName,
                        // turns Test Management into Test Management Version (Version)
                        Name = $"{nameFormatted} {Decimal.Parse(txtVersion.Text).ToString("0.0")}",
                        Version = Decimal.Parse(txtVersion.Text),
                        ReleaseDate = dtpProdDate.Value
                    };

                    context.Add(product); // add product to db
                    context.SaveChanges(); // save changes
                     
                    formMain.updateLstBox(); // update main form

                    clearTxtBoxes();
                }
                // if type modify, don't need to validate productname,
                // find product by product code(prodID) and update
                else if (type == "Modify" && validator.checkIsSentence(txtName.Text, "Name")
                    && validator.checkIsDecimal(txtVersion.Text, "Version"))
                {
                    var product = context.Products.Find(prodId);

                    // If product is not null, update product
                    if (product != null)
                    {
                        // turns Test Management into Test Management Version (Version)
                        product.Name = $"{nameFormatted} {Decimal.Parse(txtVersion.Text).ToString("0.0")}";
                        product.Version = Decimal.Parse(txtVersion.Text);
                        product.ReleaseDate = dtpProdDate.Value;

                        context.SaveChanges(); // save changes to db
                        formMain.updateLstBox(); // update main form

                        MessageBox.Show($"{product.ProductCode} has been updated."); // inform user
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        /// <summary>
        /// Formats product name from "Test Version" 1.0 to "Test Version"
        /// </summary>
        /// <param name="str">String parameter to be formated</param>
        /// <returns></returns>
        private string formatName(string str)
        {
            string[] nameSplit = str.Split(" ");
            string nameFormatted = "";
            Regex reg = new Regex("^[a-zA-Z/ ]+$");

            //if string contains only letters add it to nameFormatted 
            foreach (string w in nameSplit)
            {
                if (reg.IsMatch(w))
                    nameFormatted += $"{char.ToUpper(w[0]) + w.Substring(1).ToLower()} ";
            };

            return nameFormatted.TrimEnd();
        }

        /// <summary>
        /// Allows either backspace or letter for Product code
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtProdCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back) e.Handled = true;
        }

        /// <summary>
        /// Allows space, letter and backspace for Product Name
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != (char)Keys.Space)
                e.Handled = true;
        }

        /// <summary>
        /// Allows digits, backspace and '.' for Product version
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtVersion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '.')
                e.Handled = true;
        }

        /// <summary>
        /// Allows digits, backspace and '/' for Product date
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)Keys.Back && e.KeyChar != '/')
                e.Handled = true;
        }
    }
}
