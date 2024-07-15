/*
 * AUTHOR: GAVIN OIAMO
 * DATE: 2024/07/03
 * PURPOSE: CLASS FOR MAIN FORM
 */

using System.Collections.Generic;
using System.Diagnostics;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using ProductMaintenance.Data;
using ProductMaintenance.Models;

namespace ProductMaintenance
{
    public partial class Form1 : Form
    {
        TechSupportContext context = new TechSupportContext(); // db

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Closes form when exit button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// Opens modify form when modify button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnModify_Click(object sender, EventArgs e)
        {
            try // validate that an item has been selected
            {
                if (lstProducts.SelectedItem == null) throw new Exception("You must select an item");
                openModify("Modify");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Update ListBox when the form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                updateLstBox();
            }
            catch (SqlException)
            {
                MessageBox.Show($"There was a sql error. \n At: Form1_Load",
                    "Sql Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"There was an unexpected error \n {ex.Message} \n At: Form1_Load", 
                    "Unexpected error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Open Add form when add button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            openModify("Add");
        }

        /// <summary>
        /// Opens a new dialog to either modify or add data
        /// </summary>
        /// <param name="type">Declares the type ie "Add" or "Modify"</param>
        private void openModify(string type)
        {
            string prodId = ""; // for product code

            // turns ListBox string into Product code -> "TEST10"
            if (lstProducts.SelectedItem != null)
                prodId = lstProducts.SelectedItem.ToString()
                    .Substring(0, 14)
                    .TrimEnd();

            Form modify = new Modify(type, this, prodId);
            modify.ShowDialog();
        }

        /// <summary>
        /// Updates listbox with products when called
        /// </summary>
        public void updateLstBox()
        {
            lstProducts.Items.Clear(); // clears listbox
            
            
                var products = context.Products.Select(p => new // Queries for all products
                {
                    p.ProductCode,
                    p.Name,
                    p.Version,
                    ReleaseDate = p.ReleaseDate.ToString("dd/MM/yyyy",
                System.Globalization.CultureInfo.InvariantCulture)
                }).ToList();

                if (products == null) throw new Exception("Query could not complete \n At: updateLstBox()");

                foreach (var p in products) // foreach product, add it into the listbox
                {
                    lstProducts.Items.Add(
                        $"{p.ProductCode.TrimEnd().PadRight(14)}{p.Name.PadRight(33)}" +
                        $"{p.Version.ToString().PadRight(8)}{p.ReleaseDate}");
                }
            

            
        }

        /// <summary>
        /// Handles remove button click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                // check that an item has been selected
                if (lstProducts.SelectedItem == null)
                    throw new Exception("You must select an item");

                // confirm user wants to remove product
                DialogResult answer = MessageBox.Show("Are you sure you want to remove this product?",
                    "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (answer == DialogResult.Yes)
                {
                    // gets ProductCode ie "Test10"
                    var prodId = lstProducts.SelectedItem.ToString().Substring(0, 14).TrimEnd();

                    // Query for product
                    var product = context.Products
                      .AsNoTracking()
                      .FirstOrDefault(p => p.ProductCode.Equals(prodId));

                    context.Products.Remove(product); // remove product
                    context.SaveChanges(); // save changes
                    updateLstBox(); // update listbox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
