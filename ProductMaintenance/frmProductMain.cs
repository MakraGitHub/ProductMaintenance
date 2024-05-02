using ProductMaintenance.classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProductMaintenance
{
    public partial class frmProductMain : Form
    {
        public frmProductMain()
        {
            InitializeComponent();
        }

       // private List<Product> products = null;
        private ProductList products = new ProductList();

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

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            frmNewProduct newProductForm = new frmNewProduct();
            Product product = newProductForm.GetNewProduct();

            if (product != null)
            {
                products.Add(product);
                products.Save();
                FillProductListBox();
            }
          
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {

            int i = lstProducts.SelectedIndex;

            if (i != -1)
            {
                Product product = products[i];
                string message = "Are you wante to delete"
                    + product.Description + "?";

                DialogResult button = MessageBox.Show(message, "Comfirm delete", MessageBoxButtons.YesNo);

                //I think the same chapter 12
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
